namespace DesignPatterns.AbstractFactory.Example.OneFile
{
    internal class OneFileExample
    {

        #region PRODUCTS
        // PRODUCTS
        internal interface IProductA
        {
            void SomeMethod();
        }

        internal interface IProductB
        {
            void SomeMethod();
        }

        #region GROUP_1
        // GROUP 1
        internal class ProductA1 : IProductA
        {
            public void SomeMethod()
            {
                Console.WriteLine("Hello! I am Product A1");
            }
        }

        internal class ProductB1 : IProductB
        {
            public void SomeMethod()
            {
                Console.WriteLine("Hello! I am Product B1");
            }
        }
        #endregion

        #region GROUP_2
        // GROUP 2
        internal class ProductA2 : IProductA
        {
            public void SomeMethod()
            {
                Console.WriteLine("Hello! I am Product A2");
            }
        }

        internal class ProductB2 : IProductB
        {
            public void SomeMethod()
            {
                Console.WriteLine("Hello! I am Product B2");
            }
        }
        #endregion

        #endregion

        #region FACTORIES

        //FACTORIES
        internal interface IAbstractFactory
        {
            IProductA CreateProductA();

            IProductB CreateProductB();
        }

        internal class Factory1 : IAbstractFactory
        {
            public IProductA CreateProductA()
            {
                return new ProductA1();
            }

            public IProductB CreateProductB()
            {
                return new ProductB1();
            }
        }

        internal class Factory2 : IAbstractFactory
        {
            public IProductA CreateProductA()
            {
                return new ProductA2();
            }

            public IProductB CreateProductB()
            {
                return new ProductB2();
            }
        }

        #endregion
    }
}
