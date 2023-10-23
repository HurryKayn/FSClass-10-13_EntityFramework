namespace Esercitazione202310_12
{
    public class Program
    {
        class Brand
        {
            public string Marca {  get; set; } 
        }

        public static void Main(string[] args)
        {

            List<Brand> Brands = new List<Brand>();
            Brands.Add(new Brand { Marca="Fiat"});
            Brands.Add(new Brand { Marca = "Alfa" });
            Brands.Add(new Brand { Marca = "BMW" });

            for (int i = 0; i < Brands.Count; i++)
            {
                string s = Brands[i].Marca;   
            }




            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}