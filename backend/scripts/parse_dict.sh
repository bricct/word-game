cat sys_dict.txt | tr '[:upper:]' '[:lower:]' | sort | uniq | sed '/[^a-z]/d' > dict.txt
