using ArticleDatabaseConnector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDatabaseConnector.ArticleData
{
    public class MockArticleData : IArticleData
    {
        private List<Article> articles = new List<Article>()
        {
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.", DatePublished = new DateTime(2021,04,23), Popularity = 43, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 5, Title = "Morbi a ipsum.", DatePublished = new DateTime(2021,06,27), Popularity = 2, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 5, Title = "Praesent blandit lacinia erat.", DatePublished = new DateTime(2021,07,20), Popularity = 4, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 8, Title = "Quisque id justo sit amet sapien dignissim vestibulum.", DatePublished = new DateTime(2021,07,25), Popularity = 57, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 1, Title = "Proin interdum mauris non ligula pellentesque ultrices.", DatePublished = new DateTime(2020,11,13), Popularity = 21, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 6, Title = "Aliquam erat volutpat.", DatePublished = new DateTime(2020,09,19), Popularity = 21, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Praesent lectus.", DatePublished = new DateTime(2021,05,05), Popularity = 18, Category = "Sex" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 5, Title = "Curabitur gravida nisi at nibh.", DatePublished = new DateTime(2020,12,25), Popularity = 74, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Vivamus vestibulum sagittis sapien.", DatePublished = new DateTime(2020,11,01), Popularity = 83, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Praesent blandit lacinia erat.", DatePublished = new DateTime(2021,08,27), Popularity = 99, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 7, Title = "Donec ut dolor.", DatePublished = new DateTime(2021,08,04), Popularity = 34, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 1, Title = "Maecenas tincidunt lacus at velit.", DatePublished = new DateTime(2021,07,06), Popularity = 22, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.", DatePublished = new DateTime(2020,09,17), Popularity = 23, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Maecenas leo odio, condimentum id, luctus nec, molestie sed, justo.", DatePublished = new DateTime(2021,04,13), Popularity = 68, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 5, Title = "Suspendisse potenti.", DatePublished = new DateTime(2020,09,02), Popularity = 79, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "In quis justo.", DatePublished = new DateTime(2021,01,13), Popularity = 36, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Pellentesque eget nunc.", DatePublished = new DateTime(2021,08,10), Popularity = 65, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", DatePublished = new DateTime(2021,07,08), Popularity = 34, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 3, Title = "Morbi non lectus.", DatePublished = new DateTime(2021,06,11), Popularity = 48, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 7, Title = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", DatePublished = new DateTime(2020,12,28), Popularity = 21, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 7, Title = "Curabitur gravida nisi at nibh.", DatePublished = new DateTime(2021,06,29), Popularity = 45, Category = "Sex" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 1, Title = "Nulla tempus.", DatePublished = new DateTime(2020,12,19), Popularity = 33, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 3, Title = "Morbi ut odio.", DatePublished = new DateTime(2021,06,19), Popularity = 68, Category = "Sex" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 2, Title = "Mauris sit amet eros.", DatePublished = new DateTime(2021,08,08), Popularity = 88, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 10, Title = "Sed sagittis.", DatePublished = new DateTime(2020,11,27), Popularity = 27, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 6, Title = "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.", DatePublished = new DateTime(2021,05,24), Popularity = 15, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 5, Title = "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla.", DatePublished = new DateTime(2021,01,09), Popularity = 15, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 7, Title = "In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.", DatePublished = new DateTime(2020,10,04), Popularity = 57, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 6, Title = "Duis mattis egestas metus.", DatePublished = new DateTime(2021,02,17), Popularity = 79, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Sed sagittis.", DatePublished = new DateTime(2021,06,14), Popularity = 2, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 7, Title = "Nulla suscipit ligula in lacus.", DatePublished = new DateTime(2020,09,10), Popularity = 95, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Duis at velit eu est congue elementum.", DatePublished = new DateTime(2021,06,09), Popularity = 82, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Integer tincidunt ante vel ipsum.", DatePublished = new DateTime(2021,02,04), Popularity = 26, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", DatePublished = new DateTime(2021,07,05), Popularity = 63, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Suspendisse potenti.", DatePublished = new DateTime(2020,11,29), Popularity = 83, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 8, Title = "Nulla ut erat id mauris vulputate elementum.", DatePublished = new DateTime(2021,04,18), Popularity = 8, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Morbi porttitor lorem id ligula.", DatePublished = new DateTime(2020,09,08), Popularity = 90, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 10, Title = "Vivamus tortor.", DatePublished = new DateTime(2020,09,22), Popularity = 96, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.", DatePublished = new DateTime(2020,11,23), Popularity = 41, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 7, Title = "Proin eu mi.", DatePublished = new DateTime(2021,02,12), Popularity = 99, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 5, Title = "Ut tellus.", DatePublished = new DateTime(2020,10,03), Popularity = 37, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 2, Title = "Maecenas pulvinar lobortis est.", DatePublished = new DateTime(2021,01,13), Popularity = 37, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Morbi vel lectus in quam fringilla rhoncus.", DatePublished = new DateTime(2020,11,26), Popularity = 53, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.", DatePublished = new DateTime(2020,11,24), Popularity = 60, Category = "Religion" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 9, Title = "Quisque id justo sit amet sapien dignissim vestibulum.", DatePublished = new DateTime(2021,06,27), Popularity = 77, Category = "Sex" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 8, Title = "In sagittis dui vel nisl.", DatePublished = new DateTime(2021,02,28), Popularity = 14, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 6, Title = "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", DatePublished = new DateTime(2021,08,19), Popularity = 44, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Praesent blandit.", DatePublished = new DateTime(2020,11,10), Popularity = 72, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 3, Title = "Duis consequat dui nec nisi volutpat eleifend.", DatePublished = new DateTime(2021,01,21), Popularity = 88, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 8, Title = "In est risus, auctor sed, tristique in, tempus sit amet, sem.", DatePublished = new DateTime(2021,01,06), Popularity = 83, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 2, Title = "Vivamus tortor.", DatePublished = new DateTime(2021,02,03), Popularity = 96, Category = "Sex" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 4, Title = "Phasellus id sapien in sapien iaculis congue.", DatePublished = new DateTime(2020,12,25), Popularity = 23, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 8, Title = "Proin eu mi.", DatePublished = new DateTime(2021,04,05), Popularity = 61, Category = "Sex" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 10, Title = "In hac habitasse platea dictumst.", DatePublished = new DateTime(2021,03,28), Popularity = 23, Category = "Entertainment" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 8, Title = "Praesent lectus.", DatePublished = new DateTime(2020,11,15), Popularity = 80, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 7, Title = "Proin at turpis a pede posuere nonummy.", DatePublished = new DateTime(2020,12,28), Popularity = 29, Category = "Style" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 1, Title = "Duis aliquam convallis nunc.", DatePublished = new DateTime(2021,04,30), Popularity = 47, Category = "News" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 1, Title = "Sed ante.", DatePublished = new DateTime(2020,09,08), Popularity = 63, Category = "Sports" },
            new Article() { Id = Guid.NewGuid(), AuthorId = 1, Title = "Curabitur at ipsum ac tellus semper interdum.", DatePublished = new DateTime(2021,02,26), Popularity = 58, Category = "Entertainment" },
        };
        public Article AddArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public void DeleteArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public Article EditArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public Article GetArticle(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticles()
        {
            return articles;
        }
    }
}
