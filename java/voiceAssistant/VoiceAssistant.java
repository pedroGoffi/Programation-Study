package com.example.voice;
public class VoiceAssistant {
  public static void main(String[] args){
    Configuration config = new Configuration();

    config.setAcouseticModelPath("resource:/edu/cmu/sphinx/models/en-us/en-us");
    config.setDictionaryPath("");
    config.setLanguageModelPath("");
  }
}
