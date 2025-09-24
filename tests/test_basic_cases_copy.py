import unittest
from test_basic_cases import TestBasicCases

class TestBasicCasesCopy(unittest.TestCase):
    def setUp(self):
        pass

    def test_addition_returns_correct_result(self):
        expected = 4
        actual = 2 + 2
        self.assertEqual(expected, actual)

    def test_null_reference_throws_exception(self):
        input_value = None
        with self.assertRaises(TypeError):
            if input_value is None:
                raise TypeError("Argument cannot be None")

    def test_index_out_of_range_throws_exception(self):
        arr = [0, 0]
        with self.assertRaises(IndexError):
            _ = arr[5]

if __name__ == '__main__':
    unittest.main()
