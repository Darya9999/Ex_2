
 {
 
 string[] arr = { "hello", "2", "world", ":-)" };
 int kolRazmItv = 0;
 int curind = 0;
 
 for (int i = 0; i < arr.Length; i++) {
 if ( arr[i].Length <= 3 ) {
 kolRazmItv+=1;
 }
 }
 
 string[] otv = new string[kolRazmItv]; 
 for (int i = 0; i < arr.Length; i++) {
 if ( arr[i].Length <= 3 ) {
 otv[curind]= arr[i];
 curind+=1;
 }
 }
 
 for (int i = 0; i < otv.Length; i++) {
 Console.WriteLine(otv[i]);
 } 

 }
