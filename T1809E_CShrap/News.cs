using System;
using System.Collections.Generic;

namespace CSharp
{
    public class News : INews
    {
        public int Id;
        public string Title;
        public string PublishDate;
        public string Author;
        public string Content;
        public float AverageRate;
        int [] RateList=new int[3];

        public News()
        {
        }

        public News(int id, string title, string publishDate, string author, string content)
        {
            Id = id;
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
           
        }


        public int Id1
        {
            get => Id;
            set => Id = value;
        }

        public string Title1
        {
            get => Title;
            set => Title = value;
        }

        public string PublishDate1
        {
            get => PublishDate;
            set => PublishDate = value;
        }

        public string Author1
        {
            get => Author;
            set => Author = value;
        }

        public string Content1
        {
            get => Content;
            set => Content = value;
        }

        public float AverageRate1
        {
            get => AverageRate;
            set => AverageRate = value;
        }

        public int this[int index]
        {
            get { return RateList[index]; }
            set
            {
                if (value>=1 && value<=5)
                {
                    RateList[index] = value;
                }
                else if(value<1)
                {
                    RateList[index] = 1;
                }else if (value > 5)
                {
                    RateList[index] = 5;
                }

            }
        }

        public void Display()
        {
            
            Console.WriteLine("Id: "+Id);
            Console.WriteLine("Title: "+Title);
            Console.WriteLine("PublishDate: "+PublishDate);
            Console.WriteLine("Author: "+Author);
            Console.WriteLine("Content: "+Content);
            Console.WriteLine("AverageRate: "+AverageRate);
        }
        
       
        
        
        
        public void Calculate()
        {
            int total = 0;
            foreach (var i in RateList)
            {
                total += i;
            }

            AverageRate = (float) total / 3;
        }
    }
}