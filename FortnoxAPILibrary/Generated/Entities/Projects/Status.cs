using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    public enum Status
    {
        ///<summary> No property description </summary>
        [EnumMember(Value = "NOTSTARTED")]
        NOTSTARTED,
        ///<summary> No property description </summary>
        [EnumMember(Value = "ONGOING")]
        ONGOING,
        ///<summary> No property description </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,
    }
}