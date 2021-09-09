using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SingASong
{
	public class Song
	{

		private string song = @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!
There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!
There was an old lady who swallowed a bird;
How absurd to swallow a bird.
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!
There was an old lady who swallowed a cat;
Fancy that to swallow a cat!
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!
There was an old lady who swallowed a dog;
What a hog, to swallow a dog!
She swallowed the dog to catch the cat,
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!
There was an old lady who swallowed a cow;
I don't know how she swallowed a cow!
She swallowed the cow to catch the dog,
She swallowed the dog to catch the cat,
She swallowed the cat to catch the bird,
She swallowed the bird to catch the spider,
She swallowed the spider to catch the fly;
I don't know why she swallowed a fly - perhaps she'll die!
There was an old lady who swallowed a horse...
...She's dead, of course!";
		public Song(string[] animals)
		{
			Init(animals);
		}
		public string SingIt()
		{
			return song;
		}
		private void ReplaceAnimals(string[] animals)
		{
			if (animals != null)
			{
				this.song = this.song.Replace("fly", animals[0]);
				this.song = this.song.Replace("spider", animals[1]);
				this.song = this.song.Replace("bird", animals[2]);
				this.song = this.song.Replace("cat", animals[3]);
				this.song = this.song.Replace("dog", animals[4]);
				this.song = this.song.Replace("cow", animals[5]);
				this.song = this.song.Replace("horse", animals[6]);
				// Chapu
				//this.song = Regex.Replace(this.song, "cat", animals[3]);
				this.song = this.song.Replace("animal4ch", "catch");
			}
		}
		private void OneAnimal(string[] animals)
		{
			string[] v = this.song.Split("\n");
			string sb = "";
			sb = sb + v[0] + "\n";
			sb = sb + v[v.Length - 3] + "\n";
			sb = sb + v[v.Length - 2] + "\n";
			sb = sb + v[v.Length - 1];
			this.song = sb.ToString().Replace("fly", animals[0]);
		}
		private void TwoAnimals(string[] animals)
		{
			string[] v = this.song.Split("\n");
			string[] sb = new string[8];

			sb[0] = (v[0].Replace("fly", animals[0])) + "\n";
			sb[1] = (v[1].Replace("fly", animals[1])) + "\n";
			sb[2] = (v[2].Replace("spider", animals[1])) + "\n";
			sb[3] = v[3] + "\n";
			sb[4] = (v[4].Replace("fly", animals[0]));
			sb[4] = (sb[4].Replace("spider", animals[1])) + "\n";
			sb[5] = (v[5].Replace("fly", animals[0])) + "\n";
			sb[6] = v[v.Length - 2] + "\n";
			sb[7] = v[v.Length - 1];

			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < sb.Length; i++)
			{
				builder.Append(sb[i]);

			}
			this.song = builder.ToString();
		}
		private bool ValidateAnimals(string[] animals)
		{
			if (animals == null)
				return false;
			return true;
		}
		private void Init(string[] animals)
        {
			if (ValidateAnimals(animals))
			{
				if (animals.Length == 1)
				{
					OneAnimal(animals);
				}
				else if (animals.Length == 2)
				{
					TwoAnimals(animals);
				}
				else
				{
					ReplaceAnimals(animals);
				}
			}
		}
	}
}