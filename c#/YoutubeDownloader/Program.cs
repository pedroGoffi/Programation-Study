using System;
namespace Manager{
  public class manager{
    public bool video_mode{get;set;} 
    public bool song_mode{get;set;} 
    public string url{get;set;} 
    public string after_download_path {get;set;} 
  }
}
namespace YoutubeDownloader{
  public class GOFFI_ytbDownloader{
    private static void usage(){
      Console.WriteLine("Usage:");
      Console.WriteLine("   main.exe <option> <set target>");
      Console.WriteLine("Options:");
      Console.WriteLine("   Not implementet yet");
    }
    public static void test_conflicts(Manager.manager man){
      if(man.video_mode && man.song_mode){
        usage();
        Console.WriteLine("ERROR: Cant use song mode and video mode at the same time");
        Environment.Exit(1);
      }
      else if (man.url.Length == 0){
        usage();
        Console.WriteLine("ERROR: You must specify an URL link");
        Console.WriteLine(" To specify URL use the option: -url <your url>");
        Environment.Exit(1);
      }
    } 
    public static int Main(string[] args){
      if (args.Length == 0){
        usage();
        Console.WriteLine("ERROR: Not enough arguments.");
        Environment.Exit(1);
      }
      int ip = 0;
      var man = new Manager.manager();
      man.url = "";
      do{
        switch(args[ip]){
          case ("-s"):
          case ("--song"):
            man.song_mode = true;
            break;
          case ("-v"):
          case ("--video"):
            man.video_mode = true;
            break;
          case ("-url"):
            ++ip;
            man.url = args[ip];
            break;
          case ("-o"):
          case ("--outpath"):
          case ("--path"):
          case ("-p"):
            ++ip;
            man.after_download_path = args[ip];
            break;
        }        
        ++ip;
      } while(ip < args.Length);
      test_conflicts(man);
      // TODO:
      //    now with context run downloader.
      //    if err return 1
      return 0;
    }
  }
}
