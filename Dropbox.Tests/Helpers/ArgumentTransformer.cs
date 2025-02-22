﻿using Dropbox.API.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Dropbox.Tests.Helpers
{
    [Binding]
    public static class ArgumentTransformer
    {
        [StepArgumentTransformation(@"(activated|deactivated)")]
        [StepArgumentTransformation(@"(activate|deactivate)")]
        [StepArgumentTransformation(@"(active|inactive)")]
        [StepArgumentTransformation(@"(allocate|do not allocate)")]
        [StepArgumentTransformation(@"(are|are not)")]
        [StepArgumentTransformation(@"(can|can not)")]
        [StepArgumentTransformation(@"(check|uncheck)")]
        [StepArgumentTransformation(@"(confirm|reject)")]
        [StepArgumentTransformation(@"(contains|doesn't contain)")]
        [StepArgumentTransformation(@"(did|did not)")]
        [StepArgumentTransformation(@"(does|does not)")]
        [StepArgumentTransformation(@"(do|do not)")]
        [StepArgumentTransformation(@"(enabled|disabled)")]
        [StepArgumentTransformation(@"(Enable|Disable)")]
        [StepArgumentTransformation(@"(has|does not have)")]
        [StepArgumentTransformation(@"(has|has no)")]
        [StepArgumentTransformation(@"(has|has not)")]
        [StepArgumentTransformation(@"(have|have not)")]
        [StepArgumentTransformation(@"(is|is not)")]
        [StepArgumentTransformation(@"(on|off)")]
        [StepArgumentTransformation(@"(present|not present)")]
        [StepArgumentTransformation(@"(Release|Hide)")]
        [StepArgumentTransformation(@"(Select all|Select one)")]
        [StepArgumentTransformation(@"(shown|not shown)")]
        [StepArgumentTransformation(@"(successfully|unsuccessfully)")]
        [StepArgumentTransformation(@"(true|false)")]
        [StepArgumentTransformation(@"(with|without)")]
        [StepArgumentTransformation(@"(ascending|descending)")]
        [StepArgumentTransformation(@"DealWide|TrancheSpecific")]
        [StepArgumentTransformation(@"(select|unselect)")]
        [StepArgumentTransformation(@"(selected|unselected)")]
        [StepArgumentTransformation(@"(lock|unlock)")]
        [StepArgumentTransformation(@"(expand|collapse)")]
        public static bool HasHasNotTransformer(string value)
        {
            string[] positives =
            {
                "has", "have", "shown", "are", "is", "contains", "can", "enabled", "present", "check", "with",
                "confirm", "do", "does", "active", "allocate", "on", "successfully", "Enable", "activate", "activated","did",
                "DealWide","Release", "Select all", "true", "ascending", "select", "lock", "selected", "expand"
            };
            return positives.Any(v => v == value);
        }

        [StepArgumentTransformation]
        public static List<string> TransformToList(Table table)
        {
            return table.Rows.Select(x => x.Values.Single()).ToList();
        }

        [StepArgumentTransformation]
        public static List<Dictionary<string, string>> TransformToListOfDictionaries(Table table)
        {
            return table.Rows.Select(row => row.ToDictionary(pair => pair.Key, pair => pair.Value)).ToList();
        }

        [StepArgumentTransformation]
        public static Base ToBaseFileDto(Table table)
        {
            return table.CreateInstance<Base>();
        }

        [StepArgumentTransformation]
        public static UploadFileDto ToUploadFileDto(Table table)
        {
            return table.CreateInstance<UploadFileDto>();
        }

        [StepArgumentTransformation]
        public static FileResponseDto ToFileResponseDto(Table table)
        {
            return table.CreateInstance<FileResponseDto>();
        }
    }
}
