//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LULU_Model_DLL
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public abstract partial class User
    {
        [DataMember()]
        public int UserID { get; set; }
        [DataMember()]
        public string FirstName { get; set; }
        [DataMember()]
        public string Surname { get; set; }
        [DataMember()]
        public string Email { get; set; }
        [DataMember()]
        public string Password { get; set; }
    }
}
