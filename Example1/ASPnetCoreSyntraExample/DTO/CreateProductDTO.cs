namespace ASPnetCoreSyntraExample.DTO
{
    public class CreateProductDTO // DTO = Data Transfer Object
    {
        public string Naam { get; set; }
        public string VerbogenCode { get; set; }
        public int Prijs { get; set; }
        public int CategoryId { get; set; }

    }
}
