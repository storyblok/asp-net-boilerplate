using System.Text.Json.Serialization;
using Adliance.Storyblok;
using Adliance.Storyblok.Attributes;

namespace AspNetStoryblok.Components
{
    [StoryblokComponent("teaser")]
    public class Teaser : StoryblokComponent
    {
        [JsonPropertyName("headline")] 
        public string Headline { get; set; }
    }
}