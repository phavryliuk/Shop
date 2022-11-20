﻿using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Електромобілі", desc = "Сучасний вид транспорту" },
                    new Category
                        { categoryName = "Класичні автомобілі", desc = "Машини з двигуном внутрішнього згорання" }
                };

            }
        }
    }
}
