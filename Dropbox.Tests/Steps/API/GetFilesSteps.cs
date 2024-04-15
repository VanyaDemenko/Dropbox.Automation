using Dropbox.API.ApiFacade;
using Dropbox.API.Extensions;
using Dropbox.API.Models;
using Dropbox.Core.Helpers;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Dropbox.Tests.Steps.API
{
    [Binding]
    public sealed class GetFilesSteps
    {
        [When(@"I try to get list of all existing files")]
        public void WhenITryToGetListOfAllExistingFiles()
        {
            var response = new DropboxApi().GetFilesList();
            response.EnsureSuccessful();
            ContextHelper.AddToContext("LastApiResponse", response);
        }

        [Then(@"I should get valid list of files")]
        public void ThenIShouldGetValidListOfFiles()
        {
            var apiResponse = ContextHelper.GetFromContext<ApiResponse>("LastApiResponse");
            var filesList = apiResponse.Content<FileListResponseDto>();
            filesList.Should().NotBeNull();
            filesList.Entries.Should().NotBeNullOrEmpty();
        }

        [When(@"I try to get list of all existing files in folder")]
        public void WhenITryToGetListOfAllExistingFilesInFolder(Base folderPath)
        {
            var response = new DropboxApi().GetFilesListForFolder(folderPath);
            response.EnsureSuccessful();
            ContextHelper.AddToContext("LastApiResponse", response);
        }
    }
}
