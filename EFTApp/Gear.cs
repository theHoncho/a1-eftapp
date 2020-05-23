//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gear
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gear()
        {
            this.Loadouts = new HashSet<Loadout>();
            this.Loadouts1 = new HashSet<Loadout>();
            this.Loadouts2 = new HashSet<Loadout>();
            this.Loadouts3 = new HashSet<Loadout>();
            this.Loadouts4 = new HashSet<Loadout>();
        }
    
        public int GearID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Slot { get; set; }
        public decimal Weight { get; set; }
        public string Material { get; set; }
        public Nullable<int> Class { get; set; }
        public Nullable<int> Durability { get; set; }
        public Nullable<int> Slots { get; set; }
        public Nullable<int> MovementSpeed { get; set; }
        public Nullable<int> TurnSpeed { get; set; }
        public Nullable<int> Ergonomics { get; set; }
        public Nullable<double> RicochetChance { get; set; }
        public string SoundReduction { get; set; }
        public Nullable<bool> BlocksEarpiece { get; set; }
        public Nullable<bool> BlocksEyewear { get; set; }
        public Nullable<bool> BlocksFaceCover { get; set; }
        public Nullable<bool> BlocksHeadwear { get; set; }
        public Nullable<bool> BlocksArmour { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loadout> Loadouts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loadout> Loadouts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loadout> Loadouts2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loadout> Loadouts3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loadout> Loadouts4 { get; set; }
    }
}