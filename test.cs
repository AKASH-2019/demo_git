public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        
        IList<string> ans = new List<string>();
        int ln = words.Length;
        string cur = "";

        for(int i=0; i<ln; i++){
            
            if(cur.Length == 0){
                cur += words[i];
                j = i;
                continue;
            }

            while(i<ln && cur.Length+1+words[i].Length<= maxWidth){
                cur += words[i];
                i++;
            }

            i--;

            if(i == ln-1){
                break;
            }

            int start=j, end=i, p=0, q=0;
            int space = maxWidth - cur.Length;

            if(i-j>0 && space>0){
                p = space/(i-j);
                q = space % (i-j);
            }

            if(i-j == 0){
                p = space - 1;
                q = 0;
            }

            if(space > 0 && space <i-j){
                p = 1;
                q = 0;
            }
            string temp = "";
            for(int k=0; k<=i; k++){
                temp += words[k];
                if(q){
                    temp += " ";
                    q=0;
                }

                if(temp.size<maxWidth){
                    temp += " ";
                    
                    if(space > 0){
                        for(int kk=0; kk<p; kk++){
                            temp += " ";
                        }
                        space -= p;
                    }
                    
                }
            }
            ans.Add(temp);
            cur = "";
        }

        if(cur.Length > 0){
            int space = maxWidth - cur.Length;
            if(space>0){
                for(int k=0; k<space; k++){
                    cur += " ";
                }
            }
            ans.Add(cur);
        }

        return ans;
    }
}


// Science is what we_ _
