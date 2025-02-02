#include <iostream>
#include "Line.h"
using namespace std;

int main()
{
    string input;
    cout << "Enter a text: ";
    getline(cin, input);

    Line line(input);

    cout << "Input text: " << input << endl;
    cout << "Length of the text: " << line.getLength() << endl;

    line.sortDescending();

    cout << "Sorted text(descending): " << line.getText() << endl;

    return 0;
}