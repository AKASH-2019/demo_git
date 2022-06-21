public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        
        IList<string> ans = new List<string>();
        string cur = "";
        int j=0;
        for(int i=0; i<words.Length; i++){
            
            if(cur.Length == 0){
                cur += words[i];
                j = i;
                continue;
            }
            
            
            while(i<words.Length && cur.Length+1+words[i].Length <= maxWidth){
                cur += " " + words[i];
                i++;
            }
            i--;
            
            if(i == words.Length-1){
                break;
            }
            
            int start = j;
            int end = i;
            int q=0,p=0;
            
            if(maxWidth-cur.Length>0 && (i-j>0)){
                p = (maxWidth-cur.Length)/(i-j);
                q = (maxWidth-cur.Length)%(i-j);
            }
            if(i-j == 0){                             // "acknowledgment" (max 16)
                p = (maxWidth-cur.Length-1);        // international islamic university chittagong (max 15)
                q = 0;
            }
            if(i-j> maxWidth-cur.Length){             // "Science is what we understand well" (max 20)
                p = 1;
                q = 0;
            }
        
            string temp = "";
            int space = maxWidth-cur.Length;
            
            for(int k=j; k<=i; k++){
                temp += words[k];
                
                if(q>0){
                    temp += " ";
                    q = 0;
                }
                if(temp.Length < maxWidth){
                    temp += " ";
                    if(space > 0){
                        for(int kk=0; kk<p; kk++){
                            temp += " ";
                        };
                        space -=p;
                    }
                }
            }
            cur = "";
            ans.Add(temp);
            
        }
        if(cur.Length > 0){
            int sp = maxWidth-cur.Length;
            for(int k=0; k<sp; k++){
                cur += " ";
            }
            ans.Add(cur);
        }
        
        return ans;
    }
}


// Science is what we_ _