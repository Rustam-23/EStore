export class Category{
  id: number;
  name: string;
  }

export enum SpecificationTypeEnum {
  SpecString = 1,
  SpecDecimal,
  SpecBoolean,
}

export class Specification {
  id: number;
  name: string;
  specificationType: SpecificationTypeEnum;
  }
