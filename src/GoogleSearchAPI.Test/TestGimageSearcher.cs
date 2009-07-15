﻿//-----------------------------------------------------------------------
// <copyright file="TestGimageSearcher.cs" company="iron9light">
// Copyright (c) 2009 iron9light
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// </copyright>
// <author>iron9light@gmail.com</author>
//-----------------------------------------------------------------------

namespace Google.API.Search.Test
{
    using System;

    using NUnit.Framework;

    [TestFixture]
    public class TestGimageSearcher
    {
        [Test]
        public void GSearchTest()
        {
            var keyword = "bra";
            var start = 4;
            var resultSize = ResultSize.large;
            var imageSize = ImageSize.all;
            var colorization = Colorization.color;
            var imageType = ImageType.all;
            var fileType = FileType.jpg;
            string searchSite = null;
            var safeLevel = SafeLevel.off;

            var searchData = GimageSearcher.GSearch(
                keyword, start, resultSize, safeLevel, imageSize, colorization, imageType, fileType, searchSite);
            Assert.IsNotNull(searchData);
            Assert.IsNotNull(searchData.Results);
            Assert.Greater(searchData.Results.Length, 0);
            foreach (var result in searchData.Results)
            {
                Assert.IsNotNull(result);
                Assert.AreEqual("GimageSearch", result.GSearchResultClass);
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }

        [Test]
        public void SearchTest()
        {
            var keyword = "Virgin Islands";
            var count = 15;
            var imageSize = ImageSize.xxlarge;
            var colorization = Colorization.all;
            var imageType = ImageType.all;
            var fileType = FileType.bmp;
            string searchSite = null;
            var safeLevel = SafeLevel.active;

            var results = GimageSearcher.Search(
                keyword, count, safeLevel, imageSize, colorization, imageType, fileType, searchSite);
            Assert.IsNotNull(results);
            Assert.AreEqual(count, results.Count);
            foreach (var result in results)
            {
                Assert.IsNotNull(result);
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }

        [Test]
        public void SearchTest1()
        {
            var keyword = "x game";
            var count = 10;

            var results = GimageSearcher.Search(keyword, count);
            Assert.IsNotNull(results);
            Assert.AreEqual(count, results.Count);
            foreach (var result in results)
            {
                Assert.IsNotNull(result);
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }

        [Test]
        public void SearchTest2()
        {
            var keyword = "iPhone";
            var count = 6;
            var site = "yahoo.com";

            var results = GimageSearcher.Search(keyword, count, site);
            Assert.IsNotNull(results);
            Assert.AreEqual(count, results.Count);
            foreach (var result in results)
            {
                Assert.IsNotNull(result);
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }

        [Test]
        public void SearchTest3()
        {
            var keyword = "American Idol";
            var count = 32;
            var imageSize = ImageSize.medium;
            var colorization = Colorization.gray;
            var imageType = ImageType.face;
            var fileType = FileType.gif;

            var results = GimageSearcher.Search(keyword, count, imageSize, colorization, imageType, fileType);
            Assert.IsNotNull(results);
            Assert.AreEqual(count, results.Count);
            foreach (var result in results)
            {
                Assert.IsNotNull(result);
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }

        [Test]
        public void SearchTest4()
        {
            var keyword = "金城武";
            var count = 25;
            var imageSize = ImageSize.all;
            var colorization = Colorization.color;
            var imageType = ImageType.all;
            var fileType = FileType.jpg;
            var site = "sina.com";

            var results = GimageSearcher.Search(keyword, count, imageSize, colorization, imageType, fileType, site);
            Assert.IsNotNull(results);
            Assert.AreEqual(count, results.Count);
            foreach (var result in results)
            {
                Assert.IsNotNull(result);
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }
    }
}