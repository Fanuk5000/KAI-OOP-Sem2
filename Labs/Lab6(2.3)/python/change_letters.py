from abc_change_letters import ABC_ChangeText

class Change_letters(ABC_ChangeText):
    def __init__(self, content: str):
        if type(content) == Change_letters:
            self._content = content
        elif type(content) == str:
            self._content = content
        else:
            self._content = ''
            
    @property
    def length(self) -> int:
        return len(self._content)

    def replace(self, old_char: str, new_char: str) -> None:
        self._content = self._content.replace(old_char, new_char)

    def contains(self, substring: str) -> bool:
        return substring in self._content

    def get_content(self) -> str:
        return self._content

#--------------------------------------------------------
class TextContainer:
    def __init__(self):
        self.lines = []


    def add_line(self, line: Change_letters):
        self.lines.append(line)

    def remove_line(self, line: Change_letters):
        self.lines.remove(line)

    def clear(self):
        self.lines.clear()

    def total_characters(self) -> int:
        return sum(line.length for line in self.lines)

    def find_lines(self, substring: str) -> int:
        return sum(1 for line in self.lines if line.contains(substring))

    def replace_char_in_text(self, old_char: str, new_char: str):
        for line in self.lines:
            line.replace(old_char, new_char)

    def print_text(self):
        for line in self.lines:
            print(line.get_content())