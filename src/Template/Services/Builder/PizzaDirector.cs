﻿using Template.Domain.BorderAggregate;
using Template.Domain.IngredientsAggregate;
using Template.Domain.OrderAggregate;
using Template.Domain.RecipePizzaAggregate;
using Template.Domain.Services;
using Template.Services.Services;

namespace Template.Services.Builder
{
    public class PizzaDirector
    {
        private readonly IPizzaBuilderFactory _builderFactory;
        private IPizzaBuilder? _builder;

        public PizzaDirector(IPizzaBuilderFactory builderFactory)
        {
            _builderFactory = builderFactory;
        }

        public void BuildCustomPizza(ICollection<Ingredient> ingredients, Border border)
        {
            _builder = _builderFactory.GetBuilder(isPersonalized: true);
            _builder.Reset();
            _builder.SetName("Personalizada");
            _builder.SetBaseAmount(10);
            _builder.SetPersonalization(true); // Indica que es personalizada
            _builder.SetIngredients(ingredients); // Se puede añadir una lista de ingredientes
            _builder.SetBorder(border);
            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                _builder.SetCountPizza(2);
            }
        }

        public void BuildRecipePizza(RecipePizza recipe, Border border)
        {
            _builder = _builderFactory.GetBuilder(isPersonalized: false);
            _builder.Reset();
            _builder.SetName(recipe.Name);
            _builder.SetBaseAmount(20);
            _builder.SetPersonalization(false); // Indica que es preestablecida
            _builder.SetRecipe(recipe); // Establece la receta
            _builder.SetBorder(border);

            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                _builder.SetCountPizza(2);
            }

        }

        public Pizza ObtenerPizza()
        {
            if (_builder == null)
                throw new InvalidOperationException("Debe construir una pizza antes de obtenerla.");

            return _builder.Build();
        }


        public void AgregarIngredientePersonalizado(Ingredient ingredient)
        {
            if (_builder == null || _builder is not PizzaPersonalizedBuilder)
            {
                throw new InvalidOperationException("Solo se pueden añadir ingredientes personalizados a una pizza personalizada.");
            }

            _builder.AddIngredient(ingredient);
        }
    }
}