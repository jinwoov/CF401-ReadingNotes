import pytest

def test_enquue:
    q = Queue()
    q.enqueue("apple")
    actual = q.is_empty()
    expected = False

    assert actual == expected


def test_dequeue():
        q = Queue()
        q.