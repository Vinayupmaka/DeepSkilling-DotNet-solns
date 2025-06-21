package com.example.search;

import java.util.Scanner;

public class SearchTest {
    public static void main(String[] args) {
        Product[] products = {
                new Product(101, "Shoes", "Footwear"),
                new Product(105, "Watch", "Accessories"),
                new Product(102, "Shirt", "Clothing"),
                new Product(109, "Laptop", "Electronics")
        };

        Scanner scanner = new Scanner(System.in);
        String input;

        do {
            // Show menu
            System.out.println("\n=== Product Search Menu ===");
            System.out.println("1. Search by Product ID");
            System.out.println("2. Search by Product Name");
            System.out.println("Type 'exit' to quit.");
            System.out.print("Choose an option: ");
            input = scanner.nextLine().trim();

            switch (input) {
                case "1":
                    System.out.print("Enter the Product ID: ");
                    int id = Integer.parseInt(scanner.nextLine());

                    // Linear Search by ID
                    Product linearResult = SearchUtils.linearSearch(products, id);
                    System.out.println(linearResult != null ?
                            "Linear Search: Found - " + linearResult.prodName :
                            "Linear Search: Product not found.");

                    // Sort before Binary Search
                    SearchUtils.sortProductsById(products);
                    Product binaryResult = SearchUtils.binarySearch(products, id);
                    System.out.println(binaryResult != null ?
                            "Binary Search: Found - " + binaryResult.prodName :
                            "Binary Search: Product not found.");
                    break;

                case "2":
                    System.out.print("Enter the Product Name: ");
                    String name = scanner.nextLine();

                    Product nameResult = searchByName(products, name);
                    System.out.println(nameResult != null ?
                            "Found - " + nameResult.prodName + " (ID: " + nameResult.prodId + ")" :
                            "Product not found.");
                    break;

                case "exit":
                    System.out.println("Exiting search.");
                    break;

                default:
                    System.out.println("Invalid option. Please try again.");
            }

        } while (!input.equalsIgnoreCase("exit"));

        scanner.close();
    }
    //helper
    public static Product searchByName(Product[] products, String name) {
        for (Product product : products) {
            if (product.prodName.equalsIgnoreCase(name)) {
                return product;
            }
        }
        return null;
    }
}
