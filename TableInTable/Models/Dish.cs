//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TableInTable.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            this.RecipeSteps = new HashSet<RecipeSteps>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseServings { get; set; }
        public int CategoryId { get; set; }
        public byte[] Photo { get; set; }
        public string SourceRecipeLink { get; set; }
        public string Description { get; set; }
        public string FinalPrice { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeSteps> RecipeSteps { get; set; }
    }
}
