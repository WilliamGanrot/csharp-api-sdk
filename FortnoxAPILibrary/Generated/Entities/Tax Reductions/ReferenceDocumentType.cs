using FortnoxAPILibrary.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    public enum ReferenceDocumentType
    {
        ///<summary> No property description </summary>
        [EnumMember(Value = "OFFER")]
        OFFER,
        ///<summary> No property description </summary>
        [EnumMember(Value = "ORDER")]
        ORDER,
        ///<summary> No property description </summary>
        [EnumMember(Value = "INVOICE")]
        INVOICE,
    }
}