import {Inject, Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {Category, Specification} from "./home.models";
import {Product} from "../product/product.models";

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(private http: HttpClient) {
  }

  getAllCategories(): Observable<Category[]> {
    return this.http.get<Category[]>('category/getAllCategories');
  }

  getAllProductsByCategoryId(id: number): Observable<Product[]> {
    return this.http.get<Product[]>('category/getAllProductsByCategoryId?id=' + id);
  }

  getAllSpecificationByCategory(id: number): Observable<Specification[]> {
    return this.http.get<Specification[]>('category/getAllSpecificationByCategory?id=' + id);
  }

  getAllProductsSortByPrice(categoryId: number, minPrice: number, maxPrice: number, productOrder: number): Observable<Product[]> {
    return this.http.get<Product[]>('product/getAllProductsSortByPrice?' + `categoryId=${categoryId}&minPrice=${minPrice}&productOrder=${productOrder}&maxPrice=${maxPrice}`)
  }

  getProductById(id: number): Observable<Product[]> {
    return this.http.get<Product[]>('product/getProductById?' + `id=${id}`)
  }
}
