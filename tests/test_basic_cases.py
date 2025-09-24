import unittest

class TestBasicCases(unittest.TestCase):
    def setUp(self):
        # Setup code if needed
        pass

    def test_addition_returns_correct_result(self):
        expected = 4
        actual = 2 + 2
        self.assertEqual(expected, actual)

    def test_null_reference_throws_exception(self):
        # Edge case: None reference
        input_value = None
        with self.assertRaises(TypeError):
            # Simulate a function that expects a string and raises if None
            if input_value is None:
                raise TypeError("Argument cannot be None")

    def test_index_out_of_range_throws_exception(self):
        arr = [0, 0]
        with self.assertRaises(IndexError):
            _ = arr[5]

if __name__ == '__main__':
    unittest.main()
