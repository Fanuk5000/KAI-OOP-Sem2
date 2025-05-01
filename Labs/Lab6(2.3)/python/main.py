from change_letters import Change_letters, TextContainer

if __name__ == "__main__":
    text = TextContainer()

    text.add_line(Change_letters("Hello Amigo"))
    text.add_line(Change_letters("Zdrastvuyte, tovarishch!"))
    text.add_line(Change_letters("Example Text"))

    print(f"Original Text: {text.print_text()}")

    print("\nTotal characters:", text.total_characters())

    print("\nLines containing 'Hello':", text.find_lines("Hello"))

    text.replace_char_in_text('e', 'E')

    print("\nText after replacement:")
    text.print_text()

    text.clear()
    print("\nText after clearing:")
    text.print_text()
