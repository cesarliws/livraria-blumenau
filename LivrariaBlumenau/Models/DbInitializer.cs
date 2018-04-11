using System;
using System.Linq;

namespace LivrariaBlumenau.Models
{
    public class DbInitializer
    {
        public static void Seed(DbEntities context)
        {
            context.Database.EnsureCreated();

            if (context.Livros.Any())
            {
                return;
            }

            var livros = new Livro[]
            {
            new Livro
                {
                    Titulo = "Discovering Modern C++: An Intensive Course for Scientists, Engineers, and Programmers",
                    Autor = "Peter Gottschling",
                    Paginas = 480,
                    Edicao = "1",
                    Idioma = "English",
                    Editora = "Addison-Wesley Professional",
                    DataPublicacao = DateTime.Parse("2015-12-27"),
                    ISBN10 = "0134383583",
                    ISBN13 = "9780134383583",
                    Descricao = "As scientific and engineering projects grow larger and more complex, it is increasingly likely that those projects will be written in C++. With embedded hardware growing more powerful, much of its software is moving to C++, too. Mastering C++ gives you strong skills for programming at nearly every level, from “close to the hardware” to the highest-level abstractions. In short, C++ is a language that scientific and technical practitioners need to know.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "Web Scraping with Python: Collecting More Data from the Modern Web",
                    Autor = "Ryan Mitchell",
                    Paginas = 308,
                    Edicao = "2nd Edition",
                    Idioma = "English",
                    Editora = "O'Reilly Media",
                    DataPublicacao = DateTime.Parse("2018-04-16"),
                    ISBN10 = "1491985577",
                    ISBN13 = "9781491985571",
                    Descricao = "If programming is magic then web scraping is surely a form of wizardry. By writing a simple automated program, you can query web servers, request data, and parse it to extract the information you need. The expanded edition of this practical book not only introduces you web scraping, but also serves as a comprehensive guide to scraping almost every type of data from the modern web.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "CSS Pocket Reference: Visual Presentation for the Web",
                    Autor = "Eric A. Meyer",
                    Paginas = 208,
                    Edicao = "5th Edition",
                    Idioma = "English",
                    Editora = "O'Reilly Media",
                    DataPublicacao = DateTime.Parse("2018-04-30"),
                    ISBN10 = "1492033391",
                    ISBN13 = "9781492033394",
                    Descricao = "When you’re working with CSS and need an answer now, this concise yet comprehensive quick reference provides the essential information you need. Revised and updated for CSS3, this fifth edition is ideal for intermediate to advanced web designers and developers.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "Cloud Native Development Patterns and Best Practices",
                    Autor = "John Gilbert",
                    Paginas = 316,
                    Edicao = "1",
                    Idioma = "English",
                    Editora = "Packt Publishing",
                    DataPublicacao = DateTime.Parse("2018-02-09"),
                    ISBN10 = "1788473922",
                    ISBN13 = "9781788473927",
                    Descricao = "Build systems that leverage the benefits of the cloud and applications faster than ever before with cloud-native development. This book focuses on architectural patterns for building highly scalable cloud-native systems. You will learn how the combination of cloud, reactive principles, devops, and automation enable teams to continuously deliver innovation with confidence.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "OAuth 2.0 Cookbook",
                    Autor = "Adolfo Eloy Nascimento",
                    Paginas = 329,
                    Edicao = "1",
                    Idioma = "English",
                    Editora = "Packt Publishing",
                    DataPublicacao = DateTime.Parse("2018-01-09"),
                    ISBN10 = "178829596X",
                    ISBN13 = "9781788295963",
                    Descricao = "OAuth 2.0 is a standard protocol for authorization and it focuses on client developer simplicity while providing specific authorization flows for web applications, desktop applications, mobile phones, and so on. Given the documentation available for OAuth specification, you may think that it is complex however this book promises to explain the overall capabilities of OAuth 2.0 in simple terms. It focuses on providing specific authorization flows for various applications through interesting recipes. It also provides useful recipes for solving real life problems using Spring Security OAuth2.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "Product Management Essentials: Tools and Techniques for Becoming an Effective Technical Product Manager",
                    Autor = "Aswin Pranam",
                    Paginas = 174,
                    Edicao = "1",
                    Idioma = "English",
                    Editora = "Apress",
                    DataPublicacao = DateTime.Parse("2018-01-16"),
                    ISBN10 = "1484233026",
                    ISBN13 = "9781484233023",
                    Descricao = "Gain all of the techniques, teachings, tools, and methodologies required to be an effective first-time product manager. The overarching goal of this book is to help you understand the product manager role, give you concrete examples of what a product manager does, and build the foundational skill-set that will gear you towards a career in product management.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "Agile UX Storytelling: Crafting Stories for Better Software Development",
                    Autor = "Rebecca Baker",
                    Paginas = 144,
                    Edicao = "1",
                    Idioma = "English",
                    Editora = "Apress",
                    DataPublicacao = DateTime.Parse("2017-08-21"),
                    ISBN10 = "1484229967",
                    ISBN13 = "9781484229965",
                    Descricao = "Learn how to use stories throughout the agile software development lifecycle. Through lessons and examples, Agile UX Storytelling demonstrates to product owners, customers, scrum masters, software developers, and designers how to craft stories to facilitate communication, identify problems and patterns, refine collaborative understanding, accelerate delivery, and communicate the business value of deliverables. Rebecca Baker applies the techniques of storytelling to all facets of the software development lifecycle―planning, requirements gathering, internal and external communication, design, and testing―and shows how to use stories to improve the delivery process.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "Practical Amazon EC2, SQS, Kinesis, and S3: A Hands-On Approach to AWS",
                    Autor = "Sunil Gulabani",
                    Paginas = 312,
                    Edicao = "1",
                    Idioma = "English",
                    Editora = "Apress",
                    DataPublicacao = DateTime.Parse("2017-07-20"),
                    ISBN10 = "1484228405",
                    ISBN13 = "9781484228401",
                    Descricao = "Provide solutions to all your Amazon EC2, SQS, Kinesis, and S3 problems, including implementation using the AWS Management Console, AWS CLI, and AWS SDK (Java).",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "Machine Learning With Go",
                    Autor = "Daniel Whitenack",
                    Paginas = 304,
                    Edicao = "1",
                    Idioma = "English",
                    Editora = "Packt Publishing",
                    DataPublicacao = DateTime.Parse("2017-09-26"),
                    ISBN10 = "1785882104",
                    ISBN13 = "9781785882104",
                    Descricao = "The mission of this book is to turn readers into productive, innovative data analysts who leverage Go to build robust and valuable applications. To this end, the book clearly introduces the technical aspects of building predictive models in Go, but it also helps the reader understand how machine learning workflows are being applied in real-world scenarios.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                },
            new Livro
                {
                    Titulo = "Windows Security Monitoring: Scenarios and Patterns",
                    Autor = "Andrei Miroshnikov",
                    Paginas = 648,
                    Edicao = "1",
                    Idioma = "English",
                    Editora = "Wiley",
                    DataPublicacao = DateTime.Parse("2018-04-17"),
                    ISBN10 = "1119390648",
                    ISBN13 = "9781119390640",
                    Descricao = "Windows Security Monitoring goes beyond Windows admin and security certification guides to provide in-depth information for security professionals. Written by a Microsoft security program manager, DEFCON organizer and CISSP, this book digs deep into the underused tools that help you keep Windows systems secure. Expert guidance brings you up to speed on Windows auditing, logging, and event systems to help you exploit the full capabilities of these powerful native tools, while scenario-based instruction provides clear illustration of how these events unfold in the real world. From security monitoring and event detection to incident response procedures and best practices, this book provides detailed information on all of the security tools your Windows system has to offer.",
                    Estoque = 1,
                    CreatedAt = DateTime.Now,
                    EditedAt = DateTime.Now,
                    Active = true
                }
            };
            foreach (Livro l in livros)
            {
                context.Livros.Add(l);
            }
            context.SaveChanges();
        }
    }
}

