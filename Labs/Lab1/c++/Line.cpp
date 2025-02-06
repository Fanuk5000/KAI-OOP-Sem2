#include "Line.h"

Line::Line(const std::string &str) : text(str) {}

int Line::getLength() const
{
    return text.length();
}

std::string Line::getText() const
{
    return text;
}

void Line::sortDescending()
{
    std::sort(text.begin(), text.end(), std::greater<char>());
}