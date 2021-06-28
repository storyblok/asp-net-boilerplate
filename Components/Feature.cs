using System.Text.Json.Serialization;
using Adliance.Storyblok;
using Adliance.Storyblok.Attributes;

namespace AspNetStoryblok.Components
{
    [StoryblokComponent("feature")]
    public class Feature : StoryblokComponent
    {
        [JsonPropertyName("name")] 
        public string Name { get; set; }
    }
}