using Dropbox.API.Builders;
using Dropbox.API.Extensions;
using Dropbox.API.Models;
using Dropbox.Core.DataConstants;
using Newtonsoft.Json;

namespace Dropbox.API.ApiFacade
{
    public class DropboxApiContent
    {
        public RequestBuilder request;
        public DropboxApiContent()
        {
            request = new RequestBuilder(BaseApiConstance.ContentServiceUrl);
        }

        public ApiResponse UploadFile(UploadFileDto uploadDto, byte[] file)
        {
            var url = "files/upload";
            var requestBody = JsonConvert.SerializeObject(uploadDto);
            return request.Uri(url).Method(HttpMethod.Post)
                .WithHeader("Dropbox-API-Arg", requestBody)
                .WithFile(file)
                .Execute();
        }
    }
}
