using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Models;

namespace GraphicDesign.UI.Data.Testing
{
    public static class ModelsCreation
    {
        public static Logo[] CreateLogoArray()
        {
            return new Logo[]
            {
                new Logo()
                {
                    Name = "TechNest",
                    FilePath = "./logos/Company_TechNest.jpg",
                    CreationDate = new DateTime(2024, 11, 27),
                    Desctiption = "Prompt: Design a modern, minimalist logo that combines technology " +
                    "and innovation. Use clean lines and colors like blue or gray.",
                    Note = "preset"
                },
                new Logo()
                {
                    Name = "EcoWave",
                    FilePath = "/logos/Company_EcoWave.jpg",
                    CreationDate = new DateTime(2024, 12, 14),
                    Desctiption = "Prompt: Create a logo that combines the image of a wave with " +
                    "eco-friendly elements (e.g., leaves, trees). Use natural green and blue colors.",
                    Note = "preset"
                },
                new Logo()
                {
                    Name = "SolarSphere",
                    FilePath = "./logos/Company_SolarSphere.jpg",
                    CreationDate = new DateTime(2024, 11, 7),
                    Desctiption = "Prompt: Create a logo with a symbol of solar energy, reflecting a " +
                    "global ecological mission. Use bright colors like yellow and orange.",
                    Note = "preset"
                }, 
                new Logo()
                {
                    Name = "CloudVertex",
                    FilePath = "./logos/Company_CloudVertex.jpg",
                    CreationDate = new DateTime(2024, 10, 20),
                    Desctiption = "Prompt: Design a logo featuring cloud elements or pixelated imagery " +
                    "to represent cloud technologies. Use light blue and white colors.",
                    Note = "preset"
                },
                new Logo()
                {
                    Name = "PureLeaf",
                    FilePath = "./logos/Company_PureLeaf.jpg",
                    CreationDate = new DateTime(2024, 12, 13),
                    Desctiption = "Prompt: Design a simple and elegant logo featuring a leaf, symbolizing purity and sustainability. Use soft green shades.",
                    Note = "preset"
                },
                new Logo()
                {
                    Name = "DataForge",
                    FilePath = "./logos/Company_DataForge.jpg",
                    CreationDate = new DateTime(2024, 11, 4),
                    Desctiption = "Prompt: Create a logo that combines data elements (e.g., binary code, graphs) with the idea of forging or creation. Use strong, industrial colors like steel gray and metallic blue.",
                    Note = "preset"
                },
                new Logo()
                {
                    Name = "AquaFlow",
                    FilePath = "./logos/Company_AquaFlow.jpg",
                    CreationDate = new DateTime(2024, 12, 11),
                    Desctiption = "Prompt: Design a fluid, dynamic logo with water elements (e.g., waves or drops). Use shades of blue and turquoise.",
                    Note = "preset"
                },
            };
        }
        public static Illustration[] CreateIllustrationArray()
        {
            return new Illustration[]
            {
                new Illustration()
                {
                    Name = "EcoWave",
                    FilePath = "./illustrations/1.jpg",
                    CreationDate = new DateTime(2024, 12, 17),
                    Desctiption = "Prompt: Create an illustration of a tranquil ocean wave surrounded by lush greenery and floating leaves, symbolizing harmony between nature and water. The colors should be soft blues and greens to evoke a peaceful, eco-friendly atmosphere.",
                    Note = "preset"
                },
                new Illustration()
                {
                    Name = "TechNest",
                    FilePath = "./illustrations/2.jpg",
                    CreationDate = new DateTime(2024, 12, 5),
                    Desctiption = "Prompt: Illustrate a futuristic cityscape with high-tech buildings and flying drones, all symbolizing the concept of innovation and modern technology. Include abstract shapes and digital elements to emphasize a tech-centric vibe.",
                    Note = "preset"
                },
                new Illustration()
                {
                    Name = "SolarSphere",
                    FilePath = "./illustrations/3.jpg",
                    CreationDate = new DateTime(2024, 11, 14),
                    Desctiption = "Prompt: Create an illustration of a glowing sun at the center of a dynamic, abstract sphere with rays extending outwards, representing solar energy powering a sustainable world. Use bright yellow, orange, and subtle gradients for a solar theme.",
                    Note = "preset"
                },
                new Illustration()
                {
                    Name = "CloudVertex",
                    FilePath = "./illustrations/4.jpg",
                    CreationDate = new DateTime(2024, 12, 27),
                    Desctiption = "Prompt: Illustrate a digital cloud hovering above a city skyline, with thin digital lines and circuits extending from it, symbolizing cloud computing services. The image should look modern and tech-focused, with shades of blue, white, and silver.",
                    Note = "preset"
                },
                new Illustration()
                {
                    Name = "PureLeaf",
                    FilePath = "./illustrations/6.jpg",
                    CreationDate = new DateTime(2024, 12, 20),
                    Desctiption = "Prompt: Illustrate a single delicate leaf growing from a clean, minimalistic soil with soft light illuminating the scene. The overall tone should be serene, peaceful, and green, reflecting purity and sustainability.",
                    Note = "preset"
                },
                new Illustration()
                {
                    Name = "DataForge",
                    FilePath = "./illustrations/7.jpg",
                    CreationDate = new DateTime(2024, 11, 11),
                    Desctiption = "Prompt: Create an illustration of a digital forge or workshop, where streams of data (in the form of binary code, graphs, and charts) are being molded into powerful technology. Use deep blues, blacks, and metallic tones to create a tech-industrial atmosphere.",
                    Note = "preset"
                },
                new Illustration()
                {
                    Name = "AquaFlow",
                    FilePath = "./illustrations/8.jpg",
                    CreationDate = new DateTime(2024, 12, 16),
                    Desctiption = "Prompt: Illustrate a flowing river, with water cascading over rocks and merging with lush plant life along the banks, symbolizing clean water and natural energy. The color palette should focus on cool blues, greens, and flowing water effects.",
                    Note = "preset"
                },
            };
        }
        public static Instrument[] CreateInstrumentArray()
        {
            return new Instrument[]
            {
                new Instrument()
                {
                    Name = "ChatGPT plus",
                    Price = 20,
                    PaymentDate = new DateTime(2025, 1, 5),
                    Note = "preset",
                },
                new Instrument()
                {
                    Name = "Midjourney",
                    Price = 10m,
                    PaymentDate = new DateTime(2024, 11, 21),
                    Note = "preset",
                },
                new Instrument()
                {
                    Name = "Canva",
                    Price = 0m,
                    PaymentDate = new DateTime(2024, 11, 21),
                    Note = "preset",
                },
                new Instrument()
                {
                    Name = "Jasper.ai",
                    Price = 39m,
                    PaymentDate = new DateTime(2024, 10, 16),
                    Note = "preset",
                },
                new Instrument()
                {
                    Name = "InDesign",
                    Price = 11.03m,
                    PaymentDate = new DateTime(2024, 11, 1),
                    Note = "preset",
                },

                new Instrument()
                {
                    Name = "Illustrator",
                    Price = 11.03m,
                    PaymentDate = new DateTime(2024, 11, 1),
                    Note = "preset",
                },

                new Instrument()
                {
                    Name = "Photoshop",
                    Price = 11.03m,
                    PaymentDate = new DateTime(2024, 11, 1),
                    Note = "preset",
                },
                new Instrument()
                {
                    Name = "Creative Cloud",
                    Price = 11.03m,
                    PaymentDate = new DateTime(2025, 1, 11),
                    Note = "preset",
                },
            };
        }
        public static Order[] CreateOrderArray(List<Logo> logos, List<Illustration> illustrations, List<Instrument> instruments)
        {
            return new Order[]
            {
                new Order()
                {
                    OrderId = 0,
                    CustomerFullName = "Jonathan Smith",
                    PhoneNumber = Order.StringToPhone("+13059876543"),
                    PaymentAmount = 500m,
                    OrderState = OrderState.paid,
                    Description = "Design an eco-friendly logo featuring a wave and green leaves, reflecting sustainability and innovation.",
                    WorkResult = logos[0],
                    CreationTime = new DateTime(2024, 12, 5),
                    Deadline = new DateTime(2024, 12, 15),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 1,
                    CustomerFullName = "Jonathan Smith",
                    PhoneNumber = Order.StringToPhone("+13059876543"),
                    PaymentAmount = 750m,
                    OrderState = OrderState.paid,
                    Description = "Create a vibrant illustration of a coastal ecosystem with renewable energy elements.",
                    WorkResult = illustrations[0],
                    CreationTime = new DateTime(2024, 12, 5),
                    Deadline = new DateTime(2024, 12, 15),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 2,
                    CustomerFullName = "Emily Carter",
                    PhoneNumber = Order.StringToPhone("+16472348765"),
                    PaymentAmount = 600m,
                    OrderState = OrderState.paid,
                    Description = "Develop a sleek, futuristic logo with a nest-like structure, representing technology and security.",
                    WorkResult = logos[1],
                    CreationTime = new DateTime(2024, 12, 8),
                    Deadline = new DateTime(2024, 12, 20),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 3,
                    CustomerFullName = "Emily Carter",
                    PhoneNumber = Order.StringToPhone("+16472348765"),
                    PaymentAmount = 900m,
                    OrderState = OrderState.paid,
                    Description = "Illustrate a smart city with interconnected devices and digital infrastructure.",
                    WorkResult = illustrations[1],
                    CreationTime = new DateTime(2024, 11, 20),
                    Deadline = new DateTime(2024, 12, 1),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 4,
                    CustomerFullName = "Michael Johnson",
                    PhoneNumber = Order.StringToPhone("+447712345678"),
                    PaymentAmount = 700m,
                    OrderState = OrderState.paid,
                    Description = "Design a solar-themed logo featuring a sphere with radiating light beams.",
                    WorkResult = logos[2],
                    CreationTime = new DateTime(2024, 11, 8),
                    Deadline = new DateTime(2024, 11, 23),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 5,
                    CustomerFullName = "Michael Johnson",
                    PhoneNumber = Order.StringToPhone("+447712345678"),
                    PaymentAmount = 700m,
                    OrderState = OrderState.paid,
                    Description = "Create an artistic representation of solar panels on a futuristic landscape.",
                    WorkResult = illustrations[2],
                    CreationTime = new DateTime(2024, 11, 1),
                    Deadline = new DateTime(2024, 11, 10),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 6,
                    CustomerFullName = "Sophia Lee",
                    PhoneNumber = Order.StringToPhone("+33689123456"),
                    PaymentAmount = 550m,
                    OrderState = OrderState.sent,
                    Description = "Create a cloud-inspired logo with geometric shapes and gradients.",
                    WorkResult = logos[3],
                    CreationTime = new DateTime(2024, 11, 3),
                    Deadline = new DateTime(2024, 11, 18),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 7,
                    CustomerFullName = "Sophia Lee",
                    PhoneNumber = Order.StringToPhone("+33689123456"),
                    PaymentAmount = 800m,
                    OrderState = OrderState.sent,
                    Description = "Illustrate a data cloud with streams of information connecting to devices.",
                    WorkResult = illustrations[3],
                    CreationTime = new DateTime(2024, 10, 15),
                    Deadline = new DateTime(2024, 10, 25),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 8,
                    CustomerFullName = "Liam Walker",
                    PhoneNumber = Order.StringToPhone("+380671234567"),
                    PaymentAmount = 480m,
                    OrderState = OrderState.fail,
                    Description = "Design a modern logo with urban motifs, emphasizing transformation and progress.",
                    CreationTime = new DateTime(2024, 10, 18),
                    Deadline = new DateTime(2024, 10, 30),
                    UsedTools = new List<Instrument>(),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 9,
                    CustomerFullName = "Liam Walker",
                    PhoneNumber = Order.StringToPhone("+380671234567"),
                    PaymentAmount = 720m,
                    OrderState = OrderState.fail,
                    Description = "Create an illustration of a bustling cityscape transitioning into a greener environment.",
                    CreationTime = new DateTime(2024, 11, 10),
                    Deadline = new DateTime(2024, 11, 17),
                    UsedTools = new List<Instrument>(),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 10,
                    CustomerFullName = "Olivia Martin",
                    PhoneNumber = Order.StringToPhone("+819034567890"),
                    PaymentAmount = 530m,
                    OrderState = OrderState.paid,
                    Description = "Create a clean, minimalist logo with a single green leaf as the central element.",
                    WorkResult = logos[4],
                    CreationTime = new DateTime(2024, 11, 12),
                    Deadline = new DateTime(2024, 11, 23),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 11,
                    CustomerFullName = "Olivia Martin",
                    PhoneNumber = Order.StringToPhone("+819034567890"),
                    PaymentAmount = 810m,
                    OrderState = OrderState.paid,
                    Description = "Illustrate a serene forest scene with an emphasis on biodiversity.",
                    WorkResult = illustrations[4],
                    CreationTime = new DateTime(2024, 8, 18),
                    Deadline = new DateTime(2024, 8, 18),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 12,
                    CustomerFullName = "Ethan Davis",
                    PhoneNumber = Order.StringToPhone("+61412345678"),
                    PaymentAmount = 620m,
                    OrderState = OrderState.paid,
                    Description = "Design a logo with a forged steel look, representing strength and data integrity.",
                    WorkResult = logos[5],
                    CreationTime = new DateTime(2024, 12, 12),
                    Deadline = new DateTime(2024, 12, 24),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 13,
                    CustomerFullName = "Ethan Davis",
                    PhoneNumber = Order.StringToPhone("+61412345678"),
                    PaymentAmount = 950m,
                    OrderState = OrderState.paid,
                    Description = "Create a visualization of a data factory forging raw data into refined insights.",
                    WorkResult = illustrations[5],
                    CreationTime = new DateTime(2024, 10, 28),
                    Deadline = new DateTime(2024, 11, 12),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 14,
                    CustomerFullName = "Isabella White",
                    PhoneNumber = Order.StringToPhone("+5521987654321"),
                    PaymentAmount = 490m,
                    OrderState = OrderState.paid,
                    Description = "Develop a water-inspired logo with flowing curves and blue hues.",
                    WorkResult = logos[6],
                    CreationTime = new DateTime(2024, 12, 5),
                    Deadline = new DateTime(2024, 12, 12),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 15,
                    CustomerFullName = "Isabella White",
                    PhoneNumber = Order.StringToPhone("+5521987654321"),
                    PaymentAmount = 780m,
                    OrderState = OrderState.paid,
                    Description = "Illustrate a serene river scene with modern irrigation systems.",
                    WorkResult = illustrations[6],
                    CreationTime = new DateTime(2024, 12, 8),
                    Deadline = new DateTime(2024, 12, 18),
                    UsedTools = new List<Instrument>(new Instrument[]
                    {
                        instruments[2],
                        instruments[0],
                        instruments[7]
                    }),
                    Note = "preset"
                },
                new Order()
                {
                    OrderId = 16,
                    CustomerFullName = "Charlotte Brown",
                    PhoneNumber = Order.StringToPhone("+27823456789"),
                    PaymentAmount = 830m,
                    OrderState = OrderState.pending,
                    Description = "Design a creative logo with sparks and brain-like patterns, symbolizing ideas and innovation.",
                    CreationTime = new DateTime(2025, 1, 5),
                    Deadline = new DateTime(2025, 7, 24),
                    UsedTools = new List<Instrument>(),
                    Note = "preset"
                },
            };
        }
        public static bool CreateTestingModels(this ModelsListsSet listSet)
        {
            if(listSet == null || !listSet.isEmpty())
            {
                return false;
            }
            listSet.Logos.AddRange(CreateLogoArray());
            listSet.Illustrations.AddRange(CreateIllustrationArray());
            listSet.Instruments.AddRange(CreateInstrumentArray());
            listSet.Orders.AddRange(CreateOrderArray(listSet.Logos, listSet.Illustrations, listSet.Instruments));
            return true;
        }
    }
}
