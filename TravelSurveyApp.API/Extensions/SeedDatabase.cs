using Microsoft.EntityFrameworkCore;
using TravelSurveyApp.Data.Data;
using TravelSurveyApp.Data.Models;
using TravelSurveyApp.Data.Enums;

namespace TravelSurveyApp.API.Extensions;

public static class SeedDatabase
{
    public static async Task Seed(this ApplicationDbContext context, IServiceProvider applicationServices)
    {
        if (!await context.Companies.AnyAsync())
        {
            var companiesList = new List<Company>
{
    new Company
    {
        Name = "Solei Turism",
        Description = "Турфирма Solei Turism в Кишинёве специализируется на организации отдыха и лечения на лучших мировых курортах, отдых на море, отдых в горах, экскурсии, зимний отдых, лечебный туризм...",
        Logo = "https://solei.md/wp-content/uploads/2015/03/logo-solei1.png",
        DateOfFoundation = DateTime.Parse("2024-11-08T10:10:50.922Z").ToUniversalTime(), // Convert to UTC
        PricePolicy = PricePolicy.LowCost,
        Keywords = "экскурсии, пляжные туры, туризм в Молдове, Молдова, пляж, море, горы, горнолыжные курорты",
        Link = "https://solei.md/ru/"
    },
    new Company
    {
        Name = "Canonic Tur",
        Description = "Многопрофильный туроператор с богатой практикой и солидным объёмом услуг. В сфере туризма позиционируется как стабильная и надёжная компания...",
        Logo = "https://f1.lpcdn.site/17e850f0e19a578b9f98c6db5818c93d/13fb2793d234dd0afa10c651127a480a.png",
        DateOfFoundation = DateTime.Parse("2024-11-08T10:10:50.922Z").ToUniversalTime(), // Convert to UTC
        PricePolicy = PricePolicy.Standart,
        Keywords = "летний отдых, Болгария, Турция, Черногория, Греция, Египет, Италия...",
        Link = "https://canonic-tur.com/"
    },
    new Company
    {
        Name = "Admiral Travel",
        Description = "Admiral Travel – одна из ведущих туристических компаний в индустрии путешествий...",
        Logo = "https://admiral.travel/assets/admiral/siteimg/logo.png",
        DateOfFoundation = DateTime.Parse("2024-11-08T10:10:50.922Z").ToUniversalTime(), // Convert to UTC
        PricePolicy = PricePolicy.LowCost,
        Keywords = "экскурсии, пляжный отдых, горнолыжный отдых, экзотический отдых...",
        Link = "https://admiral.travel/ru"
    },
    new Company
    {
        Name = "Nelea-tur",
        Description = "Основным направлением работы фирмы «Nelea-Tur» является организация экскурсионных автобусных туров по Европе...",
        Logo = "https://www.neleatur.md/files/abouts/4qh9f3p05px7SJAqT0JbUcg06wG76pAg3Os0yjW3.png",
        DateOfFoundation = DateTime.Parse("2024-11-08T10:10:50.922Z").ToUniversalTime(), // Convert to UTC
        PricePolicy = PricePolicy.Premium,
        Keywords = "автобусные туры по Европе, отдых на море, авиа туры, лечение, СПА, экскурсии",
        Link = "https://www.neleatur.md/ru"
    },
    new Company
    {
        Name = "Tulip Residence & Spa Hotel",
        Description = "Этот новый 4-звездочный отель в лофт стиле предлагает удобные номера в пяти категориях...",
        Logo = "https://booking.tulipresidence.md/img/ef114d4b380aa71b.webp",
        DateOfFoundation = DateTime.Parse("2024-11-08T10:10:50.922Z").ToUniversalTime(), // Convert to UTC
        PricePolicy = PricePolicy.Premium,
        Keywords = "отель, тайский массаж, европейский массаж, хаммам, пилинг, сауна, бесплатная парковка...",
        Link = "https://booking.tulipresidence.md/"
    },
    new Company
    {
        Name = "BERD'S Hotel",
        Description = "BERD`S – это единственный отель в Молдове, входящий в альянс бренда MGallery...",
        Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-g63xso1kcp7leyfuFQrJnCO84o5809mU8w&s",
        DateOfFoundation = DateTime.Parse("2024-11-08T10:10:50.922Z").ToUniversalTime(), // Convert to UTC
        PricePolicy = PricePolicy.Premium,
        Keywords = "гостиница, ресторан, бар, СПА, красота, балийский массаж, аюрведический уход...",
        Link = "https://berdshotel.com/ru/"
    }
};


            await context.Companies.AddRangeAsync(companiesList);
            await context.SaveChangesAsync();
        }
    }
}
