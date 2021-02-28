using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.DAL
{
    public class Data
    {
        public string[] Content()
        {
            string[] IndexContent = new string[3];

            IndexContent[0] = "Hello, <br /> i'm Darek, a student of University in Gdansk. I've created this app to represent myself, i think this is one of the best ways to practice my skills. Whats skills you ask ? I think beeing a good programmer is not only to be a good programmer technically.That concerns every type of human / worker.You need to find yourself. Find yourself means finding your bad and proper sides and to know them.If you want to introduce yourself with this topic i'm sending you";
            IndexContent[1] = @"<p class=""text"">
                    In this app
                    i will try to made my own notes and objectives:
                </ p >

                < ul >
                    < li >
                        About projects that i'm actually doing
                    </ li >
                    < li >
                        About things that i've done for today even the smallest
                    </ li >
                    < li >
                        Other everyday stuff like: physical training, do the washing etc.
                    </ li >
                </ ul >

                < p class=""text"">
                    You will ask why ?
                    Beacuse all that kind of activities is a small victory.I want to see how many things i've done overtime to get my point of self-development.
                    <br />
                    ""The choices you make today won’t affect where you are in life in the short-term, but they determine where you end up in life in the long-term"" - ""The Slide Edge"" Jeff Olson
                    <br />
                </p >";

            IndexContent[2] = "Simple daily decisions made consistently over time is the only way to achieve anything meaningful. Things that are easy to do are equally easy not to do. Your daily decisions won’t affect where you are tomorrow or next week, but they will determine where you’ll be a few years from now.";
            return IndexContent;
        }
    }
}