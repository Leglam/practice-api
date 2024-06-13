using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto (this Stock stockModel) {
            return new StockDto {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                Lastdiv = stockModel.Lastdiv,
                industry = stockModel.industry,
                MarketCap = stockModel.MarketCap
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto) {
            return new Stock {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                Lastdiv = stockDto.Lastdiv,
                industry = stockDto.industry,
                MarketCap = stockDto.MarketCap
            };
        }
    }
}