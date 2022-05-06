using App1.Models;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    public class SongEquipmentViewModel
    {
        public ObservableCollection<Song> Songs { get; set; }
        public AsyncCommand RefreshComand { get; }
        public SongEquipmentViewModel()
        {

            Songs = new ObservableCollection<Song>
          {
                   new Song
                  {  name="the sunset song" , description="The Sunset song, Talyo E Shemsho, is an authentic song created in 1994 as part of the Nineveh  Children Songs Album #3. The album was entirely composed by the legendary musician Nouri Iskander. The song is a lullaby to put kids to sleep in such a beautiful setting describing the nature at night",
                      imageurl="thesunset_1920_700.jpg",  //  length="2.46m",
                  },
                  new Song { name="JOSEPH THE GARDENER" , description= "Yawse Ganono is an old traditional song in Western Surayt, originally released in 1986 by Nineveh group, under the album title 'Nineveh Children Songs - Album 1'. The song was composed by Ninos Garis and written by Augin Kurt. The song depicts the beautiful work of gardeners in the old days in TurAbdin, which is also representative of our other mountainous regions. Reviving such songs helps with promoting them among the new generation to maintain their connection with their authentic traditions, music, and culture.", imageurl= "JosephtheGardener_1920_350.jpg",  //   length="2m", 
                  },
                  new Song{ name="ANT SONG" , description="The Ant song, Shushwono, is an authentic song created in 1994 as part of the 'Nineveh Childre Songs' Album #3. The album was entirely composed by the legendary musician Nouri Iskander. The lyrics of the song was beautifully written by Shlemun Moushe. The song teaches kids resiliency, hard-working, and collaboration. Itis a masterpiece of music composition, lyrics, voice, and arrangement.", imageurl="antsong_1920_350.jpg",   //   length="3,24m",
                  },
                  new Song{ name="CANOPY OF UNITY SONG" , description="This song was written by the well-established writer, Mr. Odisho Yusep. It is a personal song given to his children. The environment is set in the plantation fields and mountains of the writer’s village (Bebede), as that inspired the lyrics of this song from landmarks of his village. The song describes two young men wearing the traditional Assyrian clothing wandering around the lands of the village to hunt and collect the daily food, and then return to their homes to build a Quprana (ܩܘܼܦܪܵܢܵܐ), a vineyard canopy. The canopy is a metaphor for the House of the Assyrian nation for people to sit underneath it united and cohesive", imageurl="qoobrana_1920_350.jpg",    //  length="3,12m",
                  },
                  new Song{ name="MOTHERS' DAY SONG" ,  //   length="3,13m",
                 imageurl="MothersSong_1920_350.jpg", description="This Mother’s Day song shows the role of a sacrificing mother and the love and care for her children. This song is a way to express gratitude to our mothers and their presence in our lives. It has been a hit since the day of its release. Remaking the song in both dialects in good and modern quality will ensure its continuity. It is a cultural song of the Ishtar Group, released in 1983, and it is written by George Chamoun and composed by Joseph Melki.",
                  },
                  new Song{ name="MOM IS COMING NOW SONG" , imageurl="momiscoming_1920_350.jpg",  description="Way back to 1951 in Egypt, 'Mama Zamanha Gaya' - 'ماما زمنها جاية', the very first filmed children's song was born in Egypt. The song was beautifully written and sung by Muhamad Fawzi, and composed by FatHi Qora. The song is about a father who is taking care of his child, while the mother is away from home. The father then keeps trying to entertain the child, while giving her/him good life lessons using beautiful and affective singing and acting. You could do the same for your child, and you can add your own version of a life lesson in the second and third parts of the song.",
                        //    length="3,11m",
                  },
              };
          

        }
   
    }
}
