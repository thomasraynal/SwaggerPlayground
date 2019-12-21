using Nancy;
using Nancy.ModelBinding;
using PetStoreApp.PetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStore.Tests
{
    public class UploadFileRequestBinder : IModelBinder
    {
        public object Bind(NancyContext context, Type modelType, object instance, BindingConfig configuration, params string[] blackList)
        {
            var uploadFileRequest = (instance as UploadFileRequest) ?? new UploadFileRequest();

            uploadFileRequest.PetId = context.Request.Query.petId;
            uploadFileRequest.AdditionalMetadata = context.Request.Form.additionalMetadata;
            uploadFileRequest.File = context.Request.Files.FirstOrDefault();

            return uploadFileRequest;
        }

        public bool CanBind(Type modelType)
        {
            return modelType == typeof(UploadFileRequest);
        }
    }
}
