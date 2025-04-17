using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Models.RSIShopModels
{


    public class RsiPricing
    {
        [JsonProperty("currencyCode")]
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("currencySymbol")]
        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }

        [JsonProperty("exchangeRate")]
        [JsonPropertyName("exchangeRate")]
        public int? ExchangeRate { get; set; }

        [JsonProperty("taxInclusive")]
        [JsonPropertyName("taxInclusive")]
        public bool? TaxInclusive { get; set; }
        public double? Tax { get; set; }

    }

    public class RsiShopCategorie
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        public bool? processed { get; set; }
        public List<RsiShopItem> Items { get; set; } = new List<RsiShopItem>();
    }


    public class ItemList
    {
        [JsonProperty("slideshow")]
        [JsonPropertyName("slideshow")]
        public string? Slideshow { get; set; }

    }
    public class ItemMedia
    {
        [JsonProperty("thumbnail")]
        [JsonPropertyName("thumbnail")]
        public ItemThumbnail Thumbnail { get; set; } = new();

        [JsonProperty("list")]
        [JsonPropertyName("list")]
        public List<ItemList> List { get; set; }

    }
    public class ItemNativPrice
    {
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        [JsonProperty("discounted")]
        [JsonPropertyName("discounted")]
        public object Discounted { get; set; }

        [JsonProperty("discountDescription")]
        [JsonPropertyName("discountDescription")]
        public object DiscountDescription { get; set; }

    }
    public class ItemPrice
    {
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        [JsonProperty("discounted")]
        [JsonPropertyName("discounted")]
        public object Discounted { get; set; }

        [JsonProperty("taxDescription")]
        [JsonPropertyName("taxDescription")]
        public List<string> TaxDescription { get; set; }

        [JsonProperty("discountDescription")]
        [JsonPropertyName("discountDescription")]
        public object DiscountDescription { get; set; }


    }
    public class RsiShopItem
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonProperty("subtitle")]
        [JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        public double ItemPrice { get; set; }
        public double Msrp { get; set; }
        public double Saving { get; set; }

        [JsonProperty("body")]
        [JsonPropertyName("body")]
        public string? Body { get; set; }

        [JsonProperty("excerpt")]
        [JsonPropertyName("excerpt")]
        public string? Excerpt { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonProperty("media")]
        [JsonPropertyName("media")]
        public ItemMedia Media { get; set; } = new();

        [JsonProperty("nativePrice")]
        [JsonPropertyName("nativePrice")]
        public ItemNativPrice NativePrice { get; set; } = new();

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public ItemPrice Price { get; set; } = new();

        [JsonProperty("stock")]
        [JsonPropertyName("stock")]
        public ItemStock Stock { get; set; }

        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonProperty("customizable")]
        [JsonPropertyName("customizable")]
        public bool? Customizable { get; set; }

        [JsonProperty("isWarbond")]
        [JsonPropertyName("isWarbond")]
        public bool? IsWarbond { get; set; }

        [JsonProperty("isPackage")]
        [JsonPropertyName("isPackage")]
        public bool? IsPackage { get; set; }

        [JsonProperty("isVip")]
        [JsonPropertyName("isVip")]
        public bool? IsVip { get; set; }

        [JsonProperty("isDirectCheckout")]
        [JsonPropertyName("isDirectCheckout")]
        public bool? IsDirectCheckout { get; set; }
        public List<string> PladgeContent { get; set; } = new();
        public bool ShowDetails { get; set; }

    }
    public class ItemStock
    {
        [JsonProperty("unlimited")]
        [JsonPropertyName("unlimited")]
        public bool? Unlimited { get; set; }

        [JsonProperty("show")]
        [JsonPropertyName("show")]
        public bool? Show { get; set; }

        [JsonProperty("available")]
        [JsonPropertyName("available")]
        public bool? Available { get; set; }

        [JsonProperty("backOrder")]
        [JsonPropertyName("backOrder")]
        public bool? BackOrder { get; set; }


    }
    public class ItemThumbnail
    {
        [JsonProperty("slideshow")]
        [JsonPropertyName("slideshow")]
        public string? Slideshow { get; set; }

        [JsonProperty("storeSmall")]
        [JsonPropertyName("storeSmall")]
        public string? StoreSmall { get; set; }


    }


    public class ManufacturerShort
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public string? Code { get; set; }
    }
    public class CCUShopItem
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("skus")]
        [JsonPropertyName("skus")]
        public List<Sku> Skus { get; set; }
    }
    public class Medias
    {
        [JsonProperty("productThumbMediumAndSmall")]
        [JsonPropertyName("productThumbMediumAndSmall")]
        public string? ProductThumbMediumAndSmall { get; set; }

        [JsonProperty("slideShow")]
        [JsonPropertyName("slideShow")]
        public string? SlideShow { get; set; }
    }
    public class ShipPriceModel
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonProperty("medias")]
        [JsonPropertyName("medias")]
        public Medias Medias { get; set; }

        [JsonProperty("manufacturer")]
        [JsonPropertyName("manufacturer")]
        public ManufacturerShort Manufacturer { get; set; }

        [JsonProperty("focus")]
        [JsonPropertyName("focus")]
        public string? Focus { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonProperty("flyableStatus")]
        [JsonPropertyName("flyableStatus")]
        public string? FlyableStatus { get; set; }

        [JsonProperty("owned")]
        [JsonPropertyName("owned")]
        public bool? Owned { get; set; }

        [JsonProperty("msrp")]
        [JsonPropertyName("msrp")]
        public int? Msrp { get; set; }
        public string? Price { get; set; }
        public string? PriceUSD { get; set; }
        [JsonProperty("link")]
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        [JsonProperty("skus")]
        [JsonPropertyName("skus")]
        public List<Sku> Skus { get; set; }
        public object UEC { get; internal set; }

    }
    public class Sku
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonProperty("available")]
        [JsonPropertyName("available")]
        public bool? Available { get; set; }

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonProperty("body")]
        [JsonPropertyName("body")]
        public string? Body { get; set; }

        [JsonProperty("unlimitedStock")]
        [JsonPropertyName("unlimitedStock")]
        public bool? UnlimitedStock { get; set; }

        [JsonProperty("availableStock")]
        [JsonPropertyName("availableStock")]
        public int? AvailableStock { get; set; }
    }




}
