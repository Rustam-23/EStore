import {Pipe, PipeTransform} from "@angular/core";
import {Product} from "../product/product.models";

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {


  transform(products: Product[], search: string = ''): Product[] {
    if (!search.trim()) {
      return products
    }
    return products.filter(product => {
      return product.name.includes(search)
    })
  }
}
