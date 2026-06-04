public class BrowserHistory {
private List<string> history = new List<string>();
private int currentIndex = 0;
private int maxIndex = 0;
    public BrowserHistory(string homepage) {
        history.Add(homepage);
        currentIndex = 0;
        maxIndex = 0;
    }
    
    public void Visit(string url) {
        currentIndex++;
        if(currentIndex<history.Count){
            history[currentIndex]=url;
        }else{
            history.Add(url);
        }
        maxIndex=currentIndex;
    }
    
    public string Back(int steps) {
        currentIndex=Math.Max(0,currentIndex-steps);
        return history[currentIndex];
    }
    
    public string Forward(int steps) {
       currentIndex=Math.Min(maxIndex,currentIndex+steps);
       return history[currentIndex] ;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */