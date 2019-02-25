using NewPieShop.Models;
using System.Collections.Generic;
using Moq;

namespace NewPieShop.Tests.MockRepos
{
    public class RepositoryMocks
    {
        public static Mock<IPieRepository> GetPieRepository()
        {
            var pies = new List<Pie>
            {
                new Pie
                {
                    Name = "Apple Pie",
                    ShortDescription = "One tasty pie",
                    LongDescription = "wojcciwjciw owkdowjk okdwojdw qjdowiejfw pqwdjweoi",
                    Price = 8.99m,
                    ImageUrl = "apple-pie.jpg",
                    ThumbnailUrl = "apple-pie.jpg",
                    IsPieOfTheWeek = true
                },
                new Pie
                {
                    Name = "Blueberry Cheese Cake",
                    ShortDescription = "You'll love it!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Price = 18.95M,
                    ImageUrl = "blueberrycheesecake.jpg",
                    ThumbnailUrl =
                        "blueberrycheesecakesmall.jpg",
                    IsPieOfTheWeek = false,
                },
                new Pie
                {
                    Name = "Cheese Cake",
                    ShortDescription = "Plain cheese cake. Plain pleasure.",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Price = 18.95M,
                    ImageUrl = "cheesecake.jpg",
                    IsPieOfTheWeek = false,
                    ThumbnailUrl = "cheesecakesmall.jpg"
                },
                new Pie
                {
                    Name = "Cherry Pie",
                    ShortDescription = "A summer classic!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    Price = 15.95M,
                    ImageUrl = "cherrypie.jpg",
                    ThumbnailUrl = "cherrypiesmall.jpg",
                    IsPieOfTheWeek = false,
                }
            };

            var mockPieRepository = new Mock<IPieRepository>();
            mockPieRepository.Setup(repo => repo.GetPies()).Returns(pies);
            mockPieRepository.Setup(repo => repo.GetPieById(It.IsAny<int>())).Returns(pies[0]);
            return mockPieRepository;
        }
    }
}
