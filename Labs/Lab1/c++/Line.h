#ifndef LINE_H
#define LINE_H

#include <string>
#include <algorithm>

class Line
{

public:
    Line(const std::string &text) : text(text) {}

    int getLength() const
    {
        return text.length();
    }

    void sortDescending()
    {
        std::sort(text.begin(), text.end(), std::greater<char>());
    }

    std::string getText() const
    {
        return text;
    }

private:
    std::string text;
};

#endif // LINE_H
