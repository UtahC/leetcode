public class Solution {
    class Vowel {
        public int position;
        public char letter;
        
        public Vowel(int p, char l) {
            this.position = p;
            this.letter = l;
        }
    }
    
    public string ReverseVowels(string s) {
        List<Vowel> list = new List<Vowel>();
        var ca = s.ToCharArray();
        for (int i = 0; i < ca.Length; i++) {
            if (ca[i] == 'a' || ca[i] == 'e' || ca[i] == 'i' || ca[i] == 'o' || ca[i] == 'u' ||
                ca[i] == 'A' || ca[i] == 'E' || ca[i] == 'I' || ca[i] == 'O' || ca[i] == 'U') {
                var v = new Vowel(i, ca[i]);
                list.Add(v);
            }
        }
        for (int i = 0; i < list.Count; i++) {
            ca[list[i].position] = list[list.Count - i - 1].letter;
        }
        return new string(ca);
    }
}