public class Solution {
    public bool IsValid(string s) {
         Stack<char> myStack = new Stack<char>();
         foreach(char c in s){
            if(c=='(' ||c=='{'||c=='['){
                myStack.Push(c);
            }else{
                if(myStack.Count==0)return false;
                char top=myStack.Peek();
                if((c==')' && top=='(')||(c=='}' && top=='{')
                ||(c==']' && top=='[')){
                    myStack.Pop();
                }else{
                    return false;
                }
            }

         }
         return myStack.Count==0;
    }
}
