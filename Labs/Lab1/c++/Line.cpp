#include "Line.h"
using namespace std;

Line::Line(const std::string &str) : text(str) {}

string Line::getText() const
{
    return text;
}

size_t Line::getLength() const
{
    return text.length();
}

void Line::sortDescending()
{
    sort(text.begin(), text.end(), greater<char>());
}