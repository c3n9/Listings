//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListViewTableInTable.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredient_RecipeSteps
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int RecipesId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<bool> Used { get; set; }
    
        public virtual Ingredient Ingredient { get; set; }
        public virtual RecipeSteps RecipeSteps { get; set; }
    }
}
