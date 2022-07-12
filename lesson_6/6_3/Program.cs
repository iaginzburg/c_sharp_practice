// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void DecToBinString (int number){

    string binary = "";
    while (number > 0){
        binary = number %2 + binary;
        number /=2;
    }
   Console.WriteLine(binary);
}

DecToBinString(2);
DecToBinString(45);

// void DecToEightString (int number){

//     string eight = "";
//     while (number > 0){
//         eight = number %8 + eight;
//         number /=8;
//     }
//    Console.WriteLine(eight);
// }

// DecToEightString(79);
// DecToEightString(17);
