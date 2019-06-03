using AppOverview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppOverview.Data
{
    public static class Apps
    {
        public static IEnumerable<AppModel> GetApps()
        {
            return new List<AppModel>()
            {
                new AppModel() {
                                 ID = 1,
                                 Name = "App 1",
                                 FaqItems = new FaqItem[] {
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"}
                                 },
                                 PortalUrl = "#",
                                 MoreInfoUrl = "#",
                                 FaqUrl = "#",
                                 ImageUrl = "/images/app_logo_placeholder.png",
                                 BackgroundUrl = "/images/bg_placeholder_1.jpg",
                                 IconUrl = "/images/ic_placeholder_1.png",
                                 NewsUrl = "#",
                                 KbUrl = "#"
                },

                new AppModel() {
                                 ID = 2,
                                 Name = "App 2",
                                 FaqItems = new FaqItem[] {
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"}
                                 },
                                 PortalUrl = "#",
                                 MoreInfoUrl = "#",
                                 FaqUrl = "#",
                                 ImageUrl = "/images/app_logo_placeholder.png",
                                 BackgroundUrl = "/images/bg_placeholder_2.jpg",
                                 IconUrl = "/images/ic_placeholder_2.png",
                                 NewsUrl = "#",
                                 KbUrl = "#"
                },
                new AppModel() {
                                 ID = 3,
                                 Name = "App 3",
                                 FaqItems = new FaqItem[] {
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"}
                                 },
                                 PortalUrl = "#",
                                 MoreInfoUrl = "#",
                                 FaqUrl = "#",
                                 ImageUrl = "/images/app_logo_placeholder.png",
                                 BackgroundUrl = "/images/bg_placeholder_3.jpg",
                                 IconUrl = "/images/ic_placeholder_3.png",
                                 NewsUrl = "#",
                                 KbUrl = "#"
                },
                new AppModel() {
                                 ID = 4,
                                 Name = "App 4",
                                 FaqItems = new FaqItem[] {
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"}
                                 },
                                 PortalUrl = "#",
                                 MoreInfoUrl = "#",
                                 FaqUrl = "#",
                                 ImageUrl = "/images/app_logo_placeholder.png",
                                 BackgroundUrl = "/images/bg_placeholder_4.jpg",
                                 IconUrl = "/images/ic_placeholder_4.png",
                                 NewsUrl = "#",
                                 KbUrl = "#"
                },
                new AppModel() {
                                 ID = 5,
                                 Name = "App 5",
                                 FaqItems = new FaqItem[] {
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"}
                                 },
                                 PortalUrl = "#",
                                 MoreInfoUrl = "#",
                                 FaqUrl = "#",
                                 ImageUrl = "/images/app_logo_placeholder.png",
                                 BackgroundUrl = "/images/bg_placeholder_5.jpg",
                                 IconUrl = "/images/ic_placeholder_5.png",
                                 NewsUrl = "#",
                                 KbUrl = "#"
                },
                new AppModel() {
                                 ID = 6,
                                 Name = "App 6",
                                 FaqItems = new FaqItem[] {
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"},
                                     new FaqItem() { Question = "How do I do this?", Url = "#"}
                                 },
                                 PortalUrl = "#",
                                 MoreInfoUrl = "#",
                                 FaqUrl = "#",
                                 ImageUrl = "/images/app_logo_placeholder.png",
                                 BackgroundUrl = "/images/bg_placeholder_6.jpg",
                                 IconUrl = "/images/ic_placeholder_6.png",
                                 NewsUrl = "#",
                                 KbUrl = "#"
                }
            };
        }
         
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> source, int batchSize)
        {
            using (var enumerator = source.GetEnumerator())
                while (enumerator.MoveNext())
                    yield return YieldBatchElements(enumerator, batchSize - 1);
        }

        private static IEnumerable<T> YieldBatchElements<T>(IEnumerator<T> source, int batchSize)
        {
            yield return source.Current;
            for (int i = 0; i < batchSize && source.MoveNext(); i++)
                yield return source.Current;
        }
    }
}