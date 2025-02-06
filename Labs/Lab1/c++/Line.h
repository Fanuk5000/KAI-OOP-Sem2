#ifndef LINE_H
#define LINE_H

#include <string>
#include <algorithm>

class Line
{

public:
    Line(const std::string &text);

    int getLength() const;

    void sortDescending();

    std::string getText() const;

private:
    std::string text;
};

#endif // LINE_H
