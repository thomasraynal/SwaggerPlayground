# SwaggerPlayground

Generating [Nancy](https://github.com/NancyFx/Nancy) API from swagger specification using [BeezUp dotnet-codegen](https://github.com/BeezUP/dotnet-codegen) and [Handlebars.Net](https://github.com/rexm/Handlebars.Net).

This an experimental code generator tool which allow the generation of the backbone of a service based on a swagger specification.

The idea is to generate:
- The Nancy module (i.e controller) of the service, as an abstract class allowing customization of the route behavior (specifically security issues). It should handle exception mapping with HTTP status code, given the swagger response spec for that route as well as, of course, the response status code. 
- The request DTO with its validator (using [FluentValidation](https://fluentvalidation.net/)), and default validation pattern given the swagger specs, both for the request and for the nested objects, recursively. Each validator being an extendable abstract class.
- The response DTO (the first 2XX response found on the specification), which usually is a swagger definition, rendered as an extendable partial class.
- The swagger definition objects, also with their validators, with a special attention given to the inlined object definition (rendered as ValueTuple) and enum.

```swagger
complexObjectE:
      type: object
      properties:
        pack_type:
          type: string
          enum:
            - nice
            - naughty
            - huge_bonus
            - immortal
            - stocking_killer
        team:
          type: string
          enum: [aog, au, afs, cgs, cpp, egc, fea, hl, sbr, uosp, vt]
        something:
          type: object
          additionalProperties:
            type: object
            additionalProperties:
                type: object
                properties:
                  propA:
                   type: integer
                   format: int64
                  propB:
                   type: object
                   properties:
                      propC:
                        type: integer
                        format: int64
                      propD:
                        type: object
                        additionalProperties:
                            type: object
                            additionalProperties:
                              type: string
                              format: date-time
```

```csharp
    public partial class ComplexObjectE
    {
      public Pack_type Pack_type {get; set; }
      public Team Team {get; set; }
      public IEnumerable<(string, IEnumerable<(string, ( long propA , ( long propC , IEnumerable<(string, IEnumerable<(string, DateTime )> )> propD ) propB ))> )> Something {get; set; }
    }

```
- The service interface, which, implemented, will send back to the controller the required response.

# **TL;DR:**

```swagger
swagger: "2.0"
info:
  description: "This is a sample server Petstore server.  You can find out more about Swagger at <a href=\"http://swagger.io\">http://swagger.io</a> or on irc.freenode.net, #swagger.  For this sample, you can use the api key \"special-key\" to test the authorization filters"
  version: 1.0.0
  title: Swagger Petstore YAML
  termsOfService: "http://swagger.io/terms/"
  contact:
    email: "apiteam@swagger.io"
  license:
    name: Apache 2.0
    url: "http://www.apache.org/licenses/LICENSE-2.0.html"
basePath: /v2
x-product: 
    appName: petStoreApp
    appService: petStore
[...]
paths:
  /pet:
    post:
      tags:
        - pet
      summary: Add a new pet to the store
      description: ""
      operationId: addPet
      consumes:
        - application/json
        - application/xml
      produces:
        - application/xml
        - application/json
      parameters:
        - in: body
          name: body
          description: Pet object that needs to be added to the store
          required: true
          schema:
            $ref: "#/definitions/Pet"
      responses:
        "201":
          schema:
             $ref: "#/definitions/Pet"
          description: successful operation
        "400":
          description: Invalid ID supplied
        "405":
          description: Invalid input
[...]
```

```csharp
    public interface IPetStoreService
    {
        Task< Pet > AddPet(AddPetRequest request);
     [...]
    }
```

```csharp
    public abstract class PetStoreModuleBase : NancyModule
    {
        public PetStoreModuleBase(IPetStoreService petStoreService) : base("/v2")
        {

           Post("/pet",  async (parameters, token) =>
            {
                ConfigureAddPetRequestRoute();

                return await this.EvaluateAndBind<AddPetRequest>(async (request) => await petStoreService.AddPet(request),  HttpStatusCode.Created );
            });
        }
     [...]
     
        protected virtual void ConfigureAddPetRequestRoute()
        {
        }
        
     [...]
    }
```

```csharp
    public partial class AddPetRequest
    {
        public Pet Body { get; set; }

        public override bool Equals(object obj)
        {
            return obj is AddPetRequest && obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = nameof(AddPetRequest).GetHashCode();
                if (default != Body) hashCode = (hashCode * 397) ^ Body.GetHashCode();
                return hashCode;
            }
        }
    }


    public class HttpResponseAddPet400Exception : Exception, IHasHttpServiceError
    {
      [...]
    }

    public class HttpResponseAddPet405Exception : Exception, IHasHttpServiceError
    {
      [...]
    }


    public class AddPetRequestValidator : AbstractValidator<AddPetRequest>
    {
        public AddPetRequestValidator()
        {
            RuleFor(request => request.Body).NotNull().WithMessage("Body is required");
        }
    }

}
```


```swagger
definitions:
  Pet:
    required:
      - name
      - photoUrls
    properties:
      id:
        type: integer
        format: int64
      category:
        $ref: "#/definitions/Category"
      name:
        type: string
        example: doggie
      photoUrls:
        type: array
        xml:
          name: photoUrl
          wrapped: true
        items:
          type: string
      tags:
        type: array
        xml:
          name: tag
          wrapped: true
        items:
          $ref: "#/definitions/Tag"
      petStatus:
        type: string
        description: pet status in the store
        enum:
          - available
          - pending
          - sold
    xml:
      name: Pet
```

```csharp
    public partial class Pet
    {
      public long Id {get; set; }
      public Category Category {get; set; }
      public string Name {get; set; }
      public IEnumerable< string > PhotoUrls {get; set; }
      public IEnumerable<Tag> Tags {get; set; }
      public PetStatus PetStatus {get; set; }

    }

    public abstract class PetValidatorBase : AbstractValidator<Pet>
    {
        public PetValidatorBase()
        {
                        RuleFor(dto => dto.Name).NotNull().NotEmpty().WithMessage("Name is required");
                        RuleFor(dto => dto.PhotoUrls).NotNull().WithMessage("PhotoUrls is required");
        }
    }
```

