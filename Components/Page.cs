using System.Text.Json.Serialization;
using Adliance.Storyblok;
using Adliance.Storyblok.Attributes;

namespace AspNetStoryblok.Components
{
    [StoryblokComponent("page", "Page")]
    public class Page : StoryblokComponent 
    {
        [JsonPropertyName("body")] 
        public StoryblokComponent[] Body { get; set; }
    }
}