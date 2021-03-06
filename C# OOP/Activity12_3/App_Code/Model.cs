﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Person
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Person()
    {
        this.People1 = new HashSet<Person>();
    }

    public int PersonID { get; set; }
    public string FullName { get; set; }
    public string PreferredName { get; set; }
    public string SearchName { get; set; }
    public bool IsPermittedToLogon { get; set; }
    public string LogonName { get; set; }
    public bool IsExternalLogonProvider { get; set; }
    public byte[] HashedPassword { get; set; }
    public bool IsSystemUser { get; set; }
    public bool IsEmployee { get; set; }
    public bool IsSalesperson { get; set; }
    public string UserPreferences { get; set; }
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public string EmailAddress { get; set; }
    public byte[] Photo { get; set; }
    public string CustomFields { get; set; }
    public string OtherLanguages { get; set; }
    public int LastEditedBy { get; set; }
    public System.DateTime ValidFrom { get; set; }
    public System.DateTime ValidTo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Person> People1 { get; set; }
    public virtual Person Person1 { get; set; }
}
