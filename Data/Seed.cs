﻿using FPTBook.Models;
using Microsoft.AspNetCore.Identity;

namespace FPTBook.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<FptbookContext>();

                context.Database.EnsureCreated();                

                var cateogories = new List<Category>()
                {
                    new Category { CategoryName = "Science" },
                    new Category { CategoryName = "Economics" },
                    new Category { CategoryName = "Romance" },
                    new Category { CategoryName = "Fantasy" },
                    new Category { CategoryName = "Culture" },
                    new Category { CategoryName = "Fiction" },
                    new Category { CategoryName = "Classic" },
                    new Category { CategoryName = "History" },
                    new Category { CategoryName = "Psychology" },
                    new Category { CategoryName = "Art" },
                    new Category { CategoryName = "Children" },
                    new Category { CategoryName = "Self-help" }
                };

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(cateogories);
                    context.SaveChanges();
                }

                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher { PublisherName = "Nhà Xuất Bản Thế Giới" },
                        new Publisher { PublisherName = "Nhà Xuất Bản Thanh Niên" },
                        new Publisher { PublisherName = "Nhà Xuất Bản Dân Trí" },
                        new Publisher { PublisherName = "Nhà Xuất Bản Văn Học" },
                        new Publisher { PublisherName = "Nhà Xuất Bản Phụ Nữ Việt Nam" },
                        new Publisher { PublisherName = "Nhà Xuất Bản Hà Nội" },
                    });
                    context.SaveChanges();
                }

                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author { AuthorName = "Châu Sa Đáy Mắt" },
                        new Author { AuthorName = "TRẦN VIẾT HƯNG" },
                        new Author { AuthorName = "Miêu Công Tử" },
                        new Author { AuthorName = "An" },
                        new Author { AuthorName = "Cá yêu tinh – Rei" },
                        new Author { AuthorName = "Hiên" },
                        new Author { AuthorName = "Skybooks và những người bạn" },
                        new Author { AuthorName = "Cao Minh" },
                        new Author { AuthorName = "Hạ Mer" },
                        new Author { AuthorName = "Jack London" },
                        new Author { AuthorName = "Paulo Coelho" },
                        new Author { AuthorName = "Mario Puzo" },
                        new Author { AuthorName = "Ernest Hemingway" },
                        new Author { AuthorName = "Albert Camus" },
                        new Author { AuthorName = "Fyodor Dostoevsky" },
                        new Author { AuthorName = "Esther Perel" },
                        new Author { AuthorName = "Thích Nhất Hạnh" },
                        new Author { AuthorName = "Napoleon Hill" },
                        new Author { AuthorName = "Albert Rutherford" }
                    });
                    context.SaveChanges();
                }

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book
                        {
                            BookTitle = "Đám Trẻ Ở Đại Dương Đen",
                            BookPrice = 20,
                            BookNumber = 100,
                            BookDetails =
                                "Lời độc thoại và đối thoại độc đáo, thể hiện sự u uất và tổn thương của đám trẻ.\nSự tập trung vào quá trình tự chữa lành, thể hiện hy vọng và nỗ lực của đám trẻ.",
                            PublisherId = 1,
                            AuthorId = 1,
                            Categories = new List<Category>
                            {
                                cateogories[0],
                            }
                        },
                         new Book
                         {
                             BookTitle = "Kinh Doanh Thời Trang",
                             BookPrice = 15,
                             BookNumber = 80,
                             BookDetails =
                                 "Chi tiết những việc cần thực hiện để mở và vận hành shop thời trang.\nCách tìm sản phẩm bán chạy và đặt hàng gia công hiệu quả với chi phí hợp lý.\nCách trang trí cửa hàng để giữ chân và thu hút khách mua hàng.",
                             PublisherId = 1,
                             AuthorId = 2,
                            Categories = new List<Category>
                            {
                                cateogories[1],
                            }
                         },
                         new Book
                         {
                             BookTitle = "999 Lá Thư Gửi Cho Chính Mình",
                             BookPrice = 15,
                             BookNumber = 90,
                             BookDetails =
                                 "Lá thư được chọn lọc kỹ càng, ý nghĩa và sâu sắc.\nSong ngữ Trung - Việt giúp trau dồi ngoại ngữ và kiến thức.\nKích thước nhỏ gọn, dễ dàng mang theo bên mình.",
                             PublisherId = 2,
                             AuthorId = 3,
                            Categories = new List<Category>
                            {
                                cateogories[2],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Tạm Biệt Tôi Của Nhiều Năm Về Trước",
                             BookPrice = 10,
                             BookNumber = 80,
                             BookDetails =
                                 "Lời khuyên và cảm nhận sâu sắc về việc buông bỏ và tìm kiếm sự thanh thản.\nMinh họa đẹp mắt và chân thực giúp hiểu rõ hơn về tổn thương bên trong.\nPhát hành bởi công ty Skybooks, có uy tín và chuyên về xuất bản sách.",
                             PublisherId = 3,
                             AuthorId = 4,
                            Categories = new List<Category>
                            {
                                cateogories[3],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Những Điều Tốt Đẹp Luôn Đúng Hạn Mà Đến",
                             BookPrice = 19,
                             BookNumber = 80,
                             BookDetails =
                                 "Thông điệp tích cực và lạc quan, giúp nhìn cuộc sống tích cực hơn.\nNội dung chân thật, trong sáng và giản dị, gần gũi và thân thiện.\nKích thước nhỏ gọn, dễ dàng mang theo bên mình.",
                             PublisherId = 4,
                             AuthorId = 5,
                            Categories = new List<Category>
                            {
                                cateogories[1],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Vẫn Là Mùa Hạ Nhưng Không Còn Chúng Ta",
                             BookPrice = 25,
                             BookNumber = 80,
                             BookDetails =
                                 "Tản văn đầy xúc cảm giúp bạn chấp nhận nỗi lo âu và ngày u ám.\nThông điệp sống bằng niềm vui, không để yêu thương thay bằng thù ghét.\nGiúp bạn hiểu về chính mình và trưởng thành mạnh mẽ dù cô đơn.",
                             PublisherId = 5,
                             AuthorId = 6,
                            Categories = new List<Category>
                            {
                                cateogories[2],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Dear, Darling",
                             BookPrice = 8,
                             BookNumber = 80,
                             BookDetails =
                                 "Kết nối tâm hồn và tạo tần số hạnh phúc, yêu thương.\nLời nhắn nhủ đánh thức hạt mầm yêu thương và trân trọng cuộc sống.\nKích thước nhỏ gọn, dễ mang theo và đọc mọi lúc mọi nơi.",
                             PublisherId = 5,
                             AuthorId = 6,
                            Categories = new List<Category>
                            {
                                cateogories[3],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Phía Trước Là Bầu Trời",
                             BookPrice = 15,
                             BookNumber = 80,
                             BookDetails =
                                 "Những câu chuyện tình yêu đẹp, ngọt ngào và ý nghĩa.\nNhững trở ngại và thách thức giúp tình yêu trở nên cường thêm.\nMột cuốn sách dành cho những người tin vào tình yêu và niềm tin.",
                             PublisherId = 6,
                             AuthorId = 7,
                            Categories = new List<Category>
                            {
                                cateogories[4],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Thiên Tài Bên Trái, Kẻ Điên Bên Phải",
                             BookPrice = 15,
                             BookNumber = 80,
                             BookDetails =
                                 "Khám phá thế giới của những người đặc biệt, kẻ gây rối và người chống đối.\nNgôn ngữ sắc sảo, sâu sắc và gần gũi, khai mở suy nghĩ và tạo động lực.\nDịch giả Thu Hương có tài và kinh nghiệm.",
                             PublisherId = 1,
                             AuthorId = 8,
                            Categories = new List<Category>
                            {
                                cateogories[4],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Mẹ làm gì có ước mơ",
                             BookPrice = 17,
                             BookNumber = 80,
                             BookDetails =
                                 "Thông điệp sâu sắc về tình yêu và hy vọng của mẹ.\nNgôn ngữ thân thiện, gần gũi và dễ hiểu.\nHình ảnh và câu chuyện đưa người đọc trở lại ký ức tuổi thơ.",
                             PublisherId = 4,
                             AuthorId = 9,
                            Categories = new List<Category>
                            {
                                cateogories[2],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Nanh Trắng Và Tiếng Gọi Của Hoang Dã",
                             BookPrice = 18,
                             BookNumber = 100,
                             BookDetails =
                                 "Tính biểu tượng và sâu sắc, thể hiện sự tranh đấu và tình yêu.\nCung cấp cái nhìn độc đáo về cuộc sống hoang dã và tương tác con người và động vật.\nNhiều người dịch, chất lượng và chính xác trong chuyển ngữ.",
                             PublisherId = 4,
                             AuthorId = 10,
                            Categories = new List<Category>
                            {
                                cateogories[1],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Nhà Giả Kim",
                             BookPrice = 10,
                             BookNumber = 100,
                             BookDetails =
                                 "Câu chuyện cổ tích giản dị, giàu chất thơ và nhân ái.\nThấm đẫm những minh triết huyền bí của phương Đông.\nCó khả năng thay đổi cuộc sống người đọc.",
                             PublisherId = 6,
                             AuthorId = 11,
                            Categories = new List<Category>
                            {
                                cateogories[2],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Bố Già",
                             BookPrice = 8,
                             BookNumber = 100,
                             BookDetails =
                                 "Cốt truyện hấp dẫn, gay cấn và đầy bất ngờ.\nNgôn ngữ giang hồ, tạo không khí kình địch đến nghẹt thở.\nTác giả nổi tiếng, chuyên viết về mafia và tội phạm.",
                             PublisherId = 4,
                             AuthorId = 12,
                            Categories = new List<Category>
                            {
                                cateogories[3],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Ông già và biển cả",
                             BookPrice = 12,
                             BookNumber = 100,
                             BookDetails =
                                 "Câu chuyện đầy cảm xúc và đối đầu cam go.\nNgôn ngữ sâu sắc và nhân vật đa chiều.\nBản dịch của giáo sư Lê Huy Bắc được đánh giá cao.",
                             PublisherId = 4,
                             AuthorId = 13,
                            Categories = new List<Category>
                            {
                                cateogories[4],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Dịch Hạch",
                             BookPrice = 14,
                             BookNumber = 100,
                             BookDetails =
                                 "Cảm động về sự đối mặt với đại dịch và nhân loại.\nBối cảnh khắc nghiệt và áp lực tạo nên câu chuyện ý nghĩa.\nNgôn ngữ sắc sảo và tinh tế tạo cảm xúc sâu sắc.",
                             PublisherId = 3,
                             AuthorId = 14,
                            Categories = new List<Category>
                            {
                                cateogories[0],
                            }
                         },
                         new Book
                         {
                             BookTitle = "TỘI ÁC VÀ HÌNH PHẠT",
                             BookPrice = 5,
                             BookNumber = 100,
                             BookDetails =
                                 "Tác giả Fyodor Dostoyevsky - một nhà văn vĩ đại.\nTội ác và hình phạt - tiểu thuyết vĩ đại nhất mọi thời.\nKích thước lớn và bìa cứng - sang trọng và bền bỉ.",
                             PublisherId = 4,
                             AuthorId = 15,
                            Categories = new List<Category>
                            {
                                cateogories[1],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Trí Thông Minh Trên Giường",
                             BookPrice = 6,
                             BookNumber = 100,
                             BookDetails =
                                 "Khám phá sự gần gũi và bí ẩn của tình dục và tình yêu.\nTác giả có kinh nghiệm lâu năm và giúp hàng trăm cặp vợ chồng duy trì hạnh phúc.\nCuốn sách đã trở thành hiện tượng toàn cầu và được dịch sang 24 ngôn ngữ.",
                             PublisherId = 2,
                             AuthorId = 16,
                            Categories = new List<Category>
                            {
                                cateogories[2],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Không Diệt Không Sinh Đừng Sợ Hãi",
                             BookPrice = 9,
                             BookNumber = 100,
                             BookDetails =
                                 "Sách mang thông điệp về sự tự do và giải thoát khỏi nỗi sợ hãi.\nThiền sư Thích Nhất Hạnh chia sẻ tri kiến sâu sắc và tế nhị về sống và chết.\nSách giúp nhìn sâu vào bản chất của sự trái ngược trong cuộc sống.",
                             PublisherId = 1,
                             AuthorId = 17,
                            Categories = new List<Category>
                            {
                                cateogories[3],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Chiến Thắng Con Quỷ Trong Bạn",
                             BookPrice = 11,
                             BookNumber = 100,
                             BookDetails =
                                 "Sách giúp bạn nhận biết và hiểu rõ hơn về sự tồn tại của Thiên thần và Ác quỷ trong con người.\nCuốn sách khám phá cuộc đối thoại sâu thẳm trong tâm thức, giúp bạn vượt qua khó khăn.\nNapoleon Hill chia sẻ hướng dẫn cụ thể để xây dựng kỷ luật tự nhân.",
                             PublisherId = 4,
                             AuthorId = 18,
                            Categories = new List<Category>
                            {
                                cateogories[4],
                            }
                         },
                         new Book
                         {
                             BookTitle = "Rèn Luyện Tư Duy Phản Biện",
                             BookPrice = 17,
                             BookNumber = 100,
                             BookDetails =
                                 "Nhận ra lý do và lý giải cho suy nghĩ khiếm khuyết của mình.\nMở rộng tầm nhìn và tri thức thông qua thu thập ý tưởng và đức tin từ mọi người.\nTham gia vào cuộc thảo luận phản biện để rèn luyện tư duy hiệu quả.",
                             PublisherId = 5,
                             AuthorId = 19,
                            Categories = new List<Category>
                            {
                                cateogories[1],
                            }
                         },
                    });
                    context.SaveChanges();
                }

                if (!context.ImageBooks.Any())
                {
                    context.ImageBooks.AddRange(new List<ImageBook>()
                     {
                         // Entries for BookId 1
                         new ImageBook { BookImage = "book-1-1.png", BookId = 1 },
                         new ImageBook { BookImage = "book-1-2.png", BookId = 1 },
                         new ImageBook { BookImage = "book-1-3.png", BookId = 1 },
                         new ImageBook { BookImage = "book-1-4.png", BookId = 1 },
                         new ImageBook { BookImage = "book-1-5.png", BookId = 1 },
                         new ImageBook { BookImage = "book-1-6.png", BookId = 1 },
                         new ImageBook { BookImage = "book-1-7.png", BookId = 1 },

                         // Entries for BookId 2
                         new ImageBook { BookImage = "book-2-1.png", BookId = 2 },
                         new ImageBook { BookImage = "book-2-2.png", BookId = 2 },
                         new ImageBook { BookImage = "book-2-3.png", BookId = 2 },
                         new ImageBook { BookImage = "book-2-4.png", BookId = 2 },
                         new ImageBook { BookImage = "book-2-5.png", BookId = 2 },
                         new ImageBook { BookImage = "book-2-6.png", BookId = 2 },
                         new ImageBook { BookImage = "book-2-7.png", BookId = 2 },

                         // Entries for BookId 3
                         new ImageBook { BookImage = "book-3-1.png", BookId = 3 },
                         new ImageBook { BookImage = "book-3-2.png", BookId = 3 },
                         new ImageBook { BookImage = "book-3-3.png", BookId = 3 },
                         new ImageBook { BookImage = "book-3-4.png", BookId = 3 },
                         new ImageBook { BookImage = "book-3-5.png", BookId = 3 },
                         new ImageBook { BookImage = "book-3-6.png", BookId = 3 },
                         new ImageBook { BookImage = "book-3-7.png", BookId = 3 },

 // Entries for BookId 4
                         new ImageBook { BookImage = "book-4-1.png", BookId = 4 },
                         new ImageBook { BookImage = "book-4-2.png", BookId = 4 },
                         new ImageBook { BookImage = "book-4-3.png", BookId = 4 },
                         new ImageBook { BookImage = "book-4-4.png", BookId = 4 },
                         new ImageBook { BookImage = "book-4-5.png", BookId = 4 },
                         new ImageBook { BookImage = "book-4-6.png", BookId = 4 },
                         new ImageBook { BookImage = "book-4-7.png", BookId = 4 },

 // Entries for BookId 5
                         new ImageBook { BookImage = "book-5-1.png", BookId = 5 },
                         new ImageBook { BookImage = "book-5-2.png", BookId = 5 },
                         new ImageBook { BookImage = "book-5-3.png", BookId = 5 },
                         new ImageBook { BookImage = "book-5-4.png", BookId = 5 },
                         new ImageBook { BookImage = "book-5-5.png", BookId = 5 },
                         new ImageBook { BookImage = "book-5-6.png", BookId = 5 },
                         new ImageBook { BookImage = "book-5-7.png", BookId = 5 },

 // Entries for BookId 6
                         new ImageBook { BookImage = "book-6-1.png", BookId = 6 },
                         new ImageBook { BookImage = "book-6-2.png", BookId = 6 },
                         new ImageBook { BookImage = "book-6-3.png", BookId = 6 },
                         new ImageBook { BookImage = "book-6-4.png", BookId = 6 },
                         new ImageBook { BookImage = "book-6-5.png", BookId = 6 },
                         new ImageBook { BookImage = "book-6-6.png", BookId = 6 },
                         new ImageBook { BookImage = "book-6-7.png", BookId = 6 },

 // Entries for BookId 7
                         new ImageBook { BookImage = "book-7-1.png", BookId = 7 },
                         new ImageBook { BookImage = "book-7-2.png", BookId = 7 },
                         new ImageBook { BookImage = "book-7-3.png", BookId = 7 },
                         new ImageBook { BookImage = "book-7-4.png", BookId = 7 },
                         new ImageBook { BookImage = "book-7-5.png", BookId = 7 },
                         new ImageBook { BookImage = "book-7-6.png", BookId = 7 },
                         new ImageBook { BookImage = "book-7-7.png", BookId = 7 },

 // Entries for BookId 8
                         new ImageBook { BookImage = "book-8-1.png", BookId = 8 },
                         new ImageBook { BookImage = "book-8-2.png", BookId = 8 },
                         new ImageBook { BookImage = "book-8-3.png", BookId = 8 },
                         new ImageBook { BookImage = "book-8-4.png", BookId = 8 },
                         new ImageBook { BookImage = "book-8-5.png", BookId = 8 },
                         new ImageBook { BookImage = "book-8-6.png", BookId = 8 },
                         new ImageBook { BookImage = "book-8-7.png", BookId = 8 },

 // Entries for BookId 9
                         new ImageBook { BookImage = "book-9-1.png", BookId = 9 },
                         new ImageBook { BookImage = "book-9-2.png", BookId = 9 },
                         new ImageBook { BookImage = "book-9-3.png", BookId = 9 },
                         new ImageBook { BookImage = "book-9-4.png", BookId = 9 },
                         new ImageBook { BookImage = "book-9-5.png", BookId = 9 },
                         new ImageBook { BookImage = "book-9-6.png", BookId = 9 },
                         new ImageBook { BookImage = "book-9-7.png", BookId = 9 },

 // Entries for BookId 10
                         new ImageBook { BookImage = "book-10-1.png", BookId = 10 },
                         new ImageBook { BookImage = "book-10-2.png", BookId = 10 },
                         new ImageBook { BookImage = "book-10-3.png", BookId = 10 },
                         new ImageBook { BookImage = "book-10-4.png", BookId = 10 },
                         new ImageBook { BookImage = "book-10-5.png", BookId = 10 },
                         new ImageBook { BookImage = "book-10-6.png", BookId = 10 },
                         new ImageBook { BookImage = "book-10-7.png", BookId = 10 },

 // Entries for BookId 11
                         new ImageBook { BookImage = "book-11-1.png", BookId = 11 },
                         new ImageBook { BookImage = "book-11-2.png", BookId = 11 },
                         new ImageBook { BookImage = "book-11-3.png", BookId = 11 },
                         new ImageBook { BookImage = "book-11-4.png", BookId = 11 },
                         new ImageBook { BookImage = "book-11-5.png", BookId = 11 },
                         new ImageBook { BookImage = "book-11-6.png", BookId = 11 },
                         new ImageBook { BookImage = "book-11-7.png", BookId = 11 },

 // Entries for BookId 12
                         new ImageBook { BookImage = "book-12-1.png", BookId = 12 },
                         new ImageBook { BookImage = "book-12-2.png", BookId = 12 },
                         new ImageBook { BookImage = "book-12-3.png", BookId = 12 },
                         new ImageBook { BookImage = "book-12-4.png", BookId = 12 },
                         new ImageBook { BookImage = "book-12-5.png", BookId = 12 },
                         new ImageBook { BookImage = "book-12-6.png", BookId = 12 },
                         new ImageBook { BookImage = "book-12-7.png", BookId = 12 },

 // Entries for BookId 13
                         new ImageBook { BookImage = "book-13-1.png", BookId = 13 },
                         new ImageBook { BookImage = "book-13-2.png", BookId = 13 },
                         new ImageBook { BookImage = "book-13-3.png", BookId = 13 },
                         new ImageBook { BookImage = "book-13-4.png", BookId = 13 },
                         new ImageBook { BookImage = "book-13-5.png", BookId = 13 },
                         new ImageBook { BookImage = "book-13-6.png", BookId = 13 },
                         new ImageBook { BookImage = "book-13-7.png", BookId = 13 },

 // Entries for BookId 14
                         new ImageBook { BookImage = "book-14-1.png", BookId = 14 },
                         new ImageBook { BookImage = "book-14-2.png", BookId = 14 },
                         new ImageBook { BookImage = "book-14-3.png", BookId = 14 },
                         new ImageBook { BookImage = "book-14-4.png", BookId = 14 },
                         new ImageBook { BookImage = "book-14-5.png", BookId = 14 },
                         new ImageBook { BookImage = "book-14-6.png", BookId = 14 },
                         new ImageBook { BookImage = "book-14-7.png", BookId = 14 },

 // Entries for BookId 15
                         new ImageBook { BookImage = "book-15-1.png", BookId = 15 },
                         new ImageBook { BookImage = "book-15-2.png", BookId = 15 },
                         new ImageBook { BookImage = "book-15-3.png", BookId = 15 },
                         new ImageBook { BookImage = "book-15-4.png", BookId = 15 },
                         new ImageBook { BookImage = "book-15-5.png", BookId = 15 },
                         new ImageBook { BookImage = "book-15-6.png", BookId = 15 },
                         new ImageBook { BookImage = "book-15-7.png", BookId = 15 },

 // Entries for BookId 16
                         new ImageBook { BookImage = "book-16-1.png", BookId = 16 },
                         new ImageBook { BookImage = "book-16-2.png", BookId = 16 },
                         new ImageBook { BookImage = "book-16-3.png", BookId = 16 },
                         new ImageBook { BookImage = "book-16-4.png", BookId = 16 },
                         new ImageBook { BookImage = "book-16-5.png", BookId = 16 },
                         new ImageBook { BookImage = "book-16-6.png", BookId = 16 },
                         new ImageBook { BookImage = "book-16-7.png", BookId = 16 },

 // Entries for BookId 17
                         new ImageBook { BookImage = "book-17-1.png", BookId = 17 },
                         new ImageBook { BookImage = "book-17-2.png", BookId = 17 },
                         new ImageBook { BookImage = "book-17-3.png", BookId = 17 },
                         new ImageBook { BookImage = "book-17-4.png", BookId = 17 },
                         new ImageBook { BookImage = "book-17-5.png", BookId = 17 },
                         new ImageBook { BookImage = "book-17-6.png", BookId = 17 },
                         new ImageBook { BookImage = "book-17-7.png", BookId = 17 },

 // Entries for BookId 18
                         new ImageBook { BookImage = "book-18-1.png", BookId = 18 },
                         new ImageBook { BookImage = "book-18-2.png", BookId = 18 },
                         new ImageBook { BookImage = "book-18-3.png", BookId = 18 },

 // Entries for BookId 19
                         new ImageBook { BookImage = "book-19-1.png", BookId = 19 },
                         new ImageBook { BookImage = "book-19-2.png", BookId = 19 },
                         new ImageBook { BookImage = "book-19-3.png", BookId = 19 },

 // Entries for BookId 20
                         new ImageBook { BookImage = "book-20-1.png", BookId = 20 },
                         new ImageBook { BookImage = "book-20-2.png", BookId = 20 },
                         new ImageBook { BookImage = "book-20-3.png", BookId = 20 },
                     });
                    context.SaveChanges();
                }

                
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();
                string adminUserEmail = "khanh123@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new User()
                    {
                        UserName = "Khanh",
                        UserFullName = "Lê Nguyễn Quốc Khánh",
                        UserSection = 1,
                        UserType = 1,
                        UserImage = "acount1.png",
                        UserAddress = "An Giang",
                        UserPhone = "0974534233",
                        UserBirthday = new DateOnly(1990, 01, 01),
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                    };

                    await userManager.CreateAsync(newAdminUser, "LeNguyenQuocKhanh123@");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }
                string adminUserEmail1 = "phat123@gmail.com";

                var adminUser1 = await userManager.FindByEmailAsync(adminUserEmail1);
                if (adminUser1 == null)
                {
                    var newAdminUser = new User()
                    {
                        UserName = "Phat",
                        UserFullName = "Vũ Tiến Phát",
                        UserSection = 1,
                        UserType = 1,
                        UserImage = "acount2.png",
                        UserAddress = "TP HCM",
                        UserPhone = "0983434675",
                        UserBirthday = new DateOnly(1998, 01, 01),
                        Email = adminUserEmail1,
                        EmailConfirmed = true,
                    };

                    await userManager.CreateAsync(newAdminUser, "VuTienPhat123@");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }
                string appUserEmail = "nghia123@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser  == null)
                {
                    var newAppUser = new User()
                    {
                        UserName = "Nghia",
                        UserFullName = "Bùi Hữu Nghĩa",
                        UserSection = 1,
                        UserType = 1,
                        UserImage = "acount3.png",
                        UserAddress = "Hóc Môn",
                        UserPhone = "0845376235",
                        UserBirthday = new DateOnly(1990, 09, 15),
                        Email = appUserEmail,
                        EmailConfirmed = true,
                    };

                    await userManager.CreateAsync(newAppUser, "BuiHuuNghia123@");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}