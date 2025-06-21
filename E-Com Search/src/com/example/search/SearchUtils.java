package com.example.search;

import java.util.Arrays;
import java.util.Comparator;

public class SearchUtils {

    // Linear search by prodId
    public static Product linearSearch(Product[] products, int targetId) {
        for (Product product : products) {
            if (product.prodId == targetId) {
                return product;
            }
        }
        return null; // not found
    }

    // Binary search by productId (array must be sorted)
    public static Product binarySearch(Product[] products, int targetId) {
        int low = 0, high = products.length - 1;

        while (low <= high) {
            int mid = (low + high) / 2;
            if (products[mid].prodId == targetId) {
                return products[mid];
            } else if (products[mid].prodId < targetId) {
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return null; // not found
    }

    // Sort array by productId (before binary search)
    public static void sortProductsById(Product[] products) {
        Arrays.sort(products, Comparator.comparingInt(p -> p.prodId));
    }
}
