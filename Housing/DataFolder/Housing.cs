//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HousingColledge.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Housing
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number_House { get; set; }
        public decimal Cost_House_Construction { get; set; }
        public decimal Additional_Cost_Apartament_House { get; set; }
        public string Name_Housing_Complex { get; set; }
        public string City { get; set; }
        public string Status_Construction_Housing_Complex { get; set; }
        public decimal Added_Value { get; set; }
        public decimal Building_Costs { get; set; }
    }
}
