using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    [Entity(SingularName = "File", PluralName = "Files")]
    public class File
    {

        ///<summary> Direct URL to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public string Url { get; private set; }

        ///<summary> Comments </summary>
        [ReadOnly]
        [JsonProperty]
        public string Comments { get; private set; }

        ///<summary> Id of the file </summary>
        [ReadOnly]
        [JsonProperty]
        public string Id { get; private set; }

        ///<summary> Archive Id of the file </summary>
        [ReadOnly]
        [JsonProperty]
        public string ArchiveId { get; private set; }

        ///<summary> Name of the file </summary>
        [ReadOnly]
        [JsonProperty]
        public string Name { get; private set; }

        ///<summary> Path to the file </summary>
        [ReadOnly]
        [JsonProperty]
        public string Path { get; private set; }

        ///<summary> Size(in bytes) of the file </summary>
        [ReadOnly]
        [JsonProperty]
        public string Size { get; private set; }
    }
}