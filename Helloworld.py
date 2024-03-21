def compute_prefix(pattern):
    """Compute the prefix ."""
    m = len(pattern)
    prefix = [0] * m
    length = 0
    i = 1
    while i < m:
        if pattern[i] == pattern[length]:
            length += 1
            prefix[i] = length
            i += 1
        else:
            if length != 0:
                length = prefix[length - 1]
            else:
                prefix[i] = 0
                i += 1
    return prefix


def kmp_search(text, pattern):
    """Search for occurrences ."""
    n = len(text)
    m = len(pattern)
    prefix = compute_prefix(pattern)
    occurrences = []

    i = 0  # Index for text
    j = 0  # Index for pattern
    while i < n:
        if pattern[j] == text[i]:
            i += 1
            j += 1

            if j == m:
                occurrences.append(i - j)
                j = prefix[j - 1]
        else:
            if j != 0:
                j = prefix[j - 1]
            else:
                i += 1
    return occurrences


# Example usage:
text = "ABABDABACDABABCABAB"
pattern = "ABABCABAB"
occurrences = kmp_search(text, pattern)
print("Pattern found at indices:", occurrences)
